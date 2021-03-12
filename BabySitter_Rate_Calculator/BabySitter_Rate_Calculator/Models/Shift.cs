using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BabySitter_Rate_Calculator.Models
{
    public class Shift
    {
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public double ShiftPay { get; set; }

        public double Calculate(Shift shift)
        {
            TimeSpan shiftLength = shift.EndTime.Subtract(shift.StartTime);
            double ShiftPay = shiftLength.TotalHours * 15;
            return ShiftPay;
        }

    }
}
