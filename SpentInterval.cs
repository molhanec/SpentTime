using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpentTime {
    class SpentInterval {

        public string Task { get; set; }

        public DateTime Start { get; set; }
        public DateTime End { get; set; }

        public SpentInterval() {
            Start = DateTime.Now;
        }

        public TimeSpan Interval {
            get {
                return End - Start;
            }
            private set { }
        }

        override public string ToString() {
            return Task + "#" + Start.ToString() + "#" + End.ToString();
        }
    }
}
