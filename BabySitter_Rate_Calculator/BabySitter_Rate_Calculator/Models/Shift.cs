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
        public double shiftRate { get; set; }

    }
}
