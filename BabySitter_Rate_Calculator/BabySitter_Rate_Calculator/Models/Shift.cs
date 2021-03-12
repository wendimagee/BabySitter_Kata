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
            double ShiftPay;
            DateTime lateRate = DateTime.Parse("11:00:00 PM");
            if (shift.EndTime > lateRate)
            {
                TimeSpan lateShiftLength = shift.EndTime.Subtract(lateRate);
                double latePay = lateShiftLength.TotalHours * 20;
                TimeSpan earlyShiftLength = lateRate.Subtract(shift.StartTime);
                double earlyPay = earlyShiftLength.TotalHours * 15;
                ShiftPay = earlyPay + latePay;
                return ShiftPay;
            }
            else
            {
                TimeSpan shiftLength = shift.EndTime.Subtract(shift.StartTime);
                ShiftPay = shiftLength.TotalHours * 15;
                return ShiftPay;
            }
        }

    }
}
