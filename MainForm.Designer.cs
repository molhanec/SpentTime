namespace SpentTime {
    partial class MainForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.next_button = new System.Windows.Forms.Button();
            this.time_label = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.stop_button = new System.Windows.Forms.Button();
            this.history_list = new System.Windows.Forms.ListView();
            this.what_column = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.start_column = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.stop_column = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.spent_time_column = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.history_menu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.history_menu_task_combo = new System.Windows.Forms.ToolStripComboBox();
            this.splitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.overview_listbox = new System.Windows.Forms.ListBox();
            this.current_task = new System.Windows.Forms.ComboBox();
            this.about_link = new System.Windows.Forms.LinkLabel();
            this.running_time_checkbox = new System.Windows.Forms.CheckBox();
            this.history_menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // next_button
            // 
            this.next_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.next_button.Location = new System.Drawing.Point(617, 413);
            this.next_button.Name = "next_button";
            this.next_button.Size = new System.Drawing.Size(75, 23);
            this.next_button.TabIndex = 0;
            this.next_button.Text = "&Next";
            this.next_button.UseVisualStyleBackColor = true;
            this.next_button.Click += new System.EventHandler(this.next_button_Click);
            // 
            // time_label
            // 
            this.time_label.Dock = System.Windows.Forms.DockStyle.Top;
            this.time_label.Font = new System.Drawing.Font("Comic Sans MS", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.time_label.Location = new System.Drawing.Point(0, 0);
            this.time_label.Name = "time_label";
            this.time_label.Size = new System.Drawing.Size(793, 45);
            this.time_label.TabIndex = 1;
            this.time_label.Text = "0:00:0";
            this.time_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // stop_button
            // 
            this.stop_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.stop_button.Location = new System.Drawing.Point(706, 413);
            this.stop_button.Name = "stop_button";
            this.stop_button.Size = new System.Drawing.Size(75, 23);
            this.stop_button.TabIndex = 3;
            this.stop_button.Text = "&Stop";
            this.stop_button.UseVisualStyleBackColor = true;
            this.stop_button.Click += new System.EventHandler(this.stop_button_Click);
            // 
            // history_list
            // 
            this.history_list.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.history_list.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.what_column,
            this.start_column,
            this.stop_column,
            this.spent_time_column});
            this.history_list.ContextMenuStrip = this.history_menu;
            this.history_list.FullRowSelect = true;
            this.history_list.Location = new System.Drawing.Point(12, 48);
            this.history_list.Name = "history_list";
            this.history_list.Size = new System.Drawing.Size(769, 247);
            this.history_list.TabIndex = 4;
            this.history_list.UseCompatibleStateImageBehavior = false;
            this.history_list.View = System.Windows.Forms.View.Details;
            // 
            // what_column
            // 
            this.what_column.Text = "What";
            this.what_column.Width = 122;
            // 
            // start_column
            // 
            this.start_column.Text = "Start";
            this.start_column.Width = 130;
            // 
            // stop_column
            // 
            this.stop_column.Text = "Stop";
            this.stop_column.Width = 147;
            // 
            // spent_time_column
            // 
            this.spent_time_column.Text = "Spent time";
            this.spent_time_column.Width = 200;
            // 
            // history_menu
            // 
            this.history_menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.history_menu_task_combo,
            this.splitToolStripMenuItem});
            this.history_menu.Name = "history_menu";
            this.history_menu.Size = new System.Drawing.Size(182, 53);
            this.history_menu.Opening += new System.ComponentModel.CancelEventHandler(this.history_menu_Opening);
            // 
            // history_menu_task_combo
            // 
            this.history_menu_task_combo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.history_menu_task_combo.Name = "history_menu_task_combo";
            this.history_menu_task_combo.Size = new System.Drawing.Size(121, 23);
            this.history_menu_task_combo.SelectedIndexChanged += new System.EventHandler(this.history_menu_task_combo_SelectedIndexChanged);
            this.history_menu_task_combo.TextUpdate += new System.EventHandler(this.history_menu_task_combo_TextUpdate);
            // 
            // splitToolStripMenuItem
            // 
            this.splitToolStripMenuItem.Name = "splitToolStripMenuItem";
            this.splitToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.splitToolStripMenuItem.Text = "&Split";
            this.splitToolStripMenuItem.Click += new System.EventHandler(this.splitToolStripMenuItem_Click);
            // 
            // overview_listbox
            // 
            this.overview_listbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.overview_listbox.FormattingEnabled = true;
            this.overview_listbox.Location = new System.Drawing.Point(12, 301);
            this.overview_listbox.Name = "overview_listbox";
            this.overview_listbox.Size = new System.Drawing.Size(599, 134);
            this.overview_listbox.TabIndex = 5;
            // 
            // current_task
            // 
            this.current_task.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.current_task.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.current_task.FormattingEnabled = true;
            this.current_task.Location = new System.Drawing.Point(617, 301);
            this.current_task.Name = "current_task";
            this.current_task.Size = new System.Drawing.Size(164, 21);
            this.current_task.TabIndex = 6;
            // 
            // about_link
            // 
            this.about_link.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.about_link.AutoSize = true;
            this.about_link.Location = new System.Drawing.Point(671, 397);
            this.about_link.Name = "about_link";
            this.about_link.Size = new System.Drawing.Size(59, 13);
            this.about_link.TabIndex = 7;
            this.about_link.TabStop = true;
            this.about_link.Text = "Homepage";
            this.about_link.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.about_link_LinkClicked);
            // 
            // running_time_checkbox
            // 
            this.running_time_checkbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.running_time_checkbox.AutoSize = true;
            this.running_time_checkbox.Location = new System.Drawing.Point(643, 351);
            this.running_time_checkbox.Name = "running_time_checkbox";
            this.running_time_checkbox.Size = new System.Drawing.Size(113, 17);
            this.running_time_checkbox.TabIndex = 8;
            this.running_time_checkbox.Text = "Show &running time";
            this.running_time_checkbox.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 448);
            this.Controls.Add(this.running_time_checkbox);
            this.Controls.Add(this.about_link);
            this.Controls.Add(this.current_task);
            this.Controls.Add(this.overview_listbox);
            this.Controls.Add(this.history_list);
            this.Controls.Add(this.stop_button);
            this.Controls.Add(this.time_label);
            this.Controls.Add(this.next_button);
            this.Name = "MainForm";
            this.Text = "Spent Time";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.history_menu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button next_button;
        private System.Windows.Forms.Label time_label;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Button stop_button;
        private System.Windows.Forms.ListView history_list;
        private System.Windows.Forms.ListBox overview_listbox;
        private System.Windows.Forms.ColumnHeader what_column;
        private System.Windows.Forms.ColumnHeader start_column;
        private System.Windows.Forms.ColumnHeader stop_column;
        private System.Windows.Forms.ColumnHeader spent_time_column;
        private System.Windows.Forms.ComboBox current_task;
        private System.Windows.Forms.ContextMenuStrip history_menu;
        private System.Windows.Forms.ToolStripComboBox history_menu_task_combo;
        private System.Windows.Forms.LinkLabel about_link;
        private System.Windows.Forms.CheckBox running_time_checkbox;
        private System.Windows.Forms.ToolStripMenuItem splitToolStripMenuItem;
    }
}

