using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpentTime {
    public partial class MainForm : Form {
        public MainForm() {
            InitializeComponent();
        }


        private SortedSet<string> tasks = new SortedSet<string>();

        private string task_file_path;
        private string history_file_path;

        private List<SpentInterval> history = new List<SpentInterval>();
        private SpentInterval current = new SpentInterval();

        private void MainForm_Load(object sender, EventArgs e) {
            string app_data_path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            string my_data_path = Path.Combine(app_data_path, "SpentTime");
            Directory.CreateDirectory(my_data_path);

            history_file_path = Path.Combine(my_data_path, "history.txt");
            load_history();
            show_history();

            // note that tasks are also populated from load_history(), so it is goo idea to call refill_tasks() after both load_xxx calls
            task_file_path = Path.Combine(my_data_path, "tasks.txt");
            load_tasks();
            refill_tasks();
        }

        private void load_tasks() {
            string line;
            try {
                using (var file = new StreamReader(task_file_path)) {
                    while ((line = file.ReadLine()) != null) {
                        line = line.Trim();
                        if (line == "") continue;
                        tasks.Add(line);
                    }
                }
            }
            catch (FileNotFoundException) {
                // no tasks, that's OK
            }
        }

        private void load_history() {
            string line;
            try {
                using (var file = new StreamReader(history_file_path)) {
                    while ((line = file.ReadLine()) != null) {
                        line = line.Trim();
                        if (line == "") continue;
                        var parts = line.Split('#');
                        if (parts.Length != 3) {
                            MessageBox.Show("Error in history file on line: " + line, "SpentTime error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            continue;
                        }
                        var item = new SpentInterval();
                        item.Task = parts[0];
                        tasks.Add(item.Task);
                        item.Start = DateTime.Parse(parts[1]);
                        item.End = DateTime.Parse(parts[2]);
                        history.Add(item);
                    }
                }
            }
            catch (FileNotFoundException) {
                // no history, that's OK
            }
        }

        private void timer_Tick(object sender, EventArgs e) {
            if (current == null) {
                time_label.Text = "Stopped";
                return;
            }
            if (running_time_checkbox.Checked)
                time_label.Text = (DateTime.Now - current.Start).ToString();
            else
                time_label.Text = "Running";
        }


        private void add_history_item(SpentInterval interval) {
            var item = new ListViewItem();
            item.Tag = interval;
            item.Text = interval.Task;
            item.SubItems.Add(interval.Start.ToString());
            item.SubItems.Add(interval.End.ToString());
            item.SubItems.Add(interval.Interval.ToString());
            history_list.Items.Add(item);
        }

        private void show_history() {
            history_list.Items.Clear();
            foreach (var history_item in history)
                add_history_item(history_item);
            update_overview();
        }

        private void next_button_Click(object sender, EventArgs e) {
            var now = DateTime.Now;
            if (current != null) {
                current.End = now;
                current.Task = current_task.Text;
                history.Add(current);
                add_history_item(current);

                tasks.Add(current_task.Text);
                refill_tasks();

                save_history();
                update_overview();
            }
            current = new SpentInterval();
            current.Start = now;
        }

        private void save_history() {
            using (var file = new StreamWriter(history_file_path)) {
                foreach (var history_item in history) {
                    file.WriteLine(history_item.ToString());
                }
            }
        }

        private void update_overview() {
            var together = new SortedDictionary<string, TimeSpan>();
            foreach (var history_item in history) {
                if (together.ContainsKey(history_item.Task))
                    together[history_item.Task] += history_item.Interval;
                else
                    together[history_item.Task] = history_item.Interval;
            }
            overview_listbox.Items.Clear();
            foreach (var overview_item in together) {
                overview_listbox.Items.Add(overview_item.Key + ": " + overview_item.Value.ToString());
            }
        }

        private void stop_button_Click(object sender, EventArgs e) {
            next_button_Click(sender, e);
            current = null;
        }

        private void refill_tasks() {
            var current = current_task.Text;
            current_task.Items.Clear();
            foreach (var task in tasks) {
                current_task.Items.Add(task);
            }
            current_task.Text = current;
            using (var file = new StreamWriter(task_file_path)) {
                foreach (var task in tasks) {
                    file.WriteLine(task);
                }
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e) {
            if (current == null) return;
            var result = MessageBox.Show("Save the currently running timing?", "SpentTime closing", 
                MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (result == DialogResult.No) return;
            if (result == DialogResult.Cancel) {
                e.Cancel = true;
                return;
            }
            stop_button_Click(sender, e);
        }

        private void history_menu_Opening(object sender, CancelEventArgs e) {
            if (history_list.SelectedItems.Count == 0) {
                e.Cancel = true;
                return;
            }
            history_menu_task_combo.Items.Clear();
            foreach (var item in tasks) {
                history_menu_task_combo.Items.Add(item);
            }
            history_menu_task_combo.Text = history_list.SelectedItems[0].Text;
        }

        private void history_menu_task_combo_SelectedIndexChanged(object sender, EventArgs e) {
            update_history_item_task(history_list.SelectedItems[0], history_menu_task_combo.Text);
        }

        private void update_history_item_task(ListViewItem item, string new_task_name) {
            item.Text = new_task_name;
            ((SpentInterval)item.Tag).Task = new_task_name;
            save_history();
            update_overview();
        }

        private void history_menu_task_combo_TextUpdate(object sender, EventArgs e) {
            update_history_item_task(history_list.SelectedItems[0], history_menu_task_combo.Text);
            tasks.Add(history_menu_task_combo.Text);
            refill_tasks();
        }

        private void about_link_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            System.Diagnostics.Process.Start("https://github.com/molhanec/SpentTime");
        }

        private void splitToolStripMenuItem_Click(object sender, EventArgs e) {
            
        }
    }
}
