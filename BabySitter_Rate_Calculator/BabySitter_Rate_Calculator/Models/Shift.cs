using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BabySitter_Rate_Calculator.Models
{
    public class Shift
    {
        public DateTime startTime { get; set; }
        public DateTime endTime { get; set; }

        public string family { get; set; }

        public double shiftLength { get; set; }


        public Shift(DateTime startTime, DateTime endTime, string family)
        {
            this.startTime = startTime;
            this.endTime = endTime;
            this.family = family;
        }

    }
}
