using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BabySitter_Rate_Calculator.Models
{
    public class Shift
    {
        [Range (typeof(DateTime), "05:00:00 PM", "11:59:59 PM",
            ErrorMessage = "Value for Start Time must be between 5:00pm and 2:00am")]
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public double ShiftPay { get; set; }

        public string ShiftFamily { get; set; }

        public double Calculate(Shift shift)
        {
            double ShiftPay;
            DateTime lateRate = DateTime.Parse("11:00:00 PM");
            if (shift.EndTime.Date > shift.StartTime.Date)
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
                var ShiftPay2 = Math.Round(shiftLength.TotalHours) * 15;
                return ShiftPay2;
            }
        }

        public double CalculateB(Shift shift)
        {
            double ShiftPay;
            DateTime tenOclock = DateTime.Parse("10:00:00 PM");
            DateTime midnight = DateTime.Parse("12:00:00 AM");
            if (shift.StartTime<tenOclock && shift.EndTime < tenOclock)
            {
                TimeSpan shiftLength = shift.EndTime.Subtract(shift.StartTime);
                ShiftPay = shiftLength.TotalHours * 12;
                return ShiftPay;
            }
            else if(shift.StartTime>= tenOclock && shift.EndTime<=midnight)
            {
                TimeSpan shiftLength = shift.EndTime.Subtract(shift.StartTime);
                var Shifty = shiftLength.TotalHours;
                var ShiftPay2 = Math.Round(Shifty) * 8;
                return Shifty;
            }
            else
            {
                TimeSpan firstShift = midnight.Subtract(shift.StartTime);
                double firstPay = firstShift.TotalHours * 8;
                TimeSpan afterMidnight = shift.EndTime.Subtract(midnight);
                double secondPay = afterMidnight.TotalHours * 20;
                ShiftPay = firstPay + secondPay;
                return ShiftPay;
            }
        }
        public double CalculateC(Shift shift)
        {
            double ShiftPay;
            var shiftEndDate = shift.EndTime.Date;
            DateTime nineOclock = shiftEndDate.AddHours(21);
            if (shift.EndTime> nineOclock)
            {
                TimeSpan earlyShiftLength = nineOclock.Subtract(shift.StartTime);
                double earlyPay = earlyShiftLength.TotalHours * 21;
                TimeSpan lateShiftLength = shift.EndTime.Subtract(nineOclock);
                double latePay = lateShiftLength.TotalHours * 15;
                ShiftPay = earlyPay + latePay;
                return ShiftPay;
            }
            else
            {
                TimeSpan shiftLength = shift.EndTime.Subtract(shift.StartTime);
                var ShiftPay2 = shiftLength.TotalHours * 21;
                return ShiftPay2;
            }
        }
       
    }
}
