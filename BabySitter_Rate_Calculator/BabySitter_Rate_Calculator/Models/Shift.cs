using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BabySitter_Rate_Calculator.Models
{
    public class Shift
    {
        public TimeSpan StartTime { get; set; }
        public TimeSpan EndTime { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public DateTime StartDateTime { get { return StartDate.Add(StartTime); }}
        public DateTime EndDateTime { get { return EndDate.Add(EndTime); } }
        public double ShiftPay { get; set; }

        public string ShiftFamily { get; set; }

        public Shift Calculate(Shift shift)
        {
            DateTime elevenOclock = shift.StartDate.AddHours(23);
            if (shift.EndDateTime.Date > shift.StartDateTime.Date)
            {
                TimeSpan lateShiftLength = shift.EndDateTime.Subtract(elevenOclock);
                double latePay = lateShiftLength.TotalHours * 20;
                TimeSpan earlyShiftLength = elevenOclock.Subtract(shift.StartDateTime);
                double earlyPay = earlyShiftLength.TotalHours * 15;
                shift.ShiftPay = earlyPay + latePay;
                return shift;
            }
            else
            {
                TimeSpan shiftLength = shift.EndDateTime.Subtract(shift.StartDateTime);
                var ShiftPay2 = Math.Round(shiftLength.TotalHours) * 15;
                shift.ShiftPay = ShiftPay2;
                return shift;
            }
        }

        public Shift CalculateB(Shift shift)
        {
            DateTime tenOclock = shift.StartDate.AddHours(22);
            DateTime midnight = shift.StartDate.AddHours(24);
            if (shift.StartDateTime<tenOclock && shift.EndDateTime < tenOclock)
            {
                TimeSpan shiftLength = shift.EndTime.Subtract(shift.StartTime);
                shift.ShiftPay = shiftLength.TotalHours * 12;
                return shift;
            }
            else if(shift.StartDateTime>= tenOclock && shift.EndDateTime<=midnight)
            {
                TimeSpan shiftLength = shift.EndDateTime.Subtract(shift.StartDateTime);
                double Shifty = shiftLength.TotalHours*8;
                shift.ShiftPay = Shifty;
                return shift;
            }
            else
            {
                TimeSpan firstShift = midnight.Subtract(shift.StartDateTime);
                double firstPay = firstShift.TotalHours * 8;
                TimeSpan afterMidnight = shift.EndDateTime.Subtract(midnight);
                double secondPay = afterMidnight.TotalHours * 12;
                shift.ShiftPay = firstPay + secondPay;
                return shift;
            }
        }
        public Shift CalculateC(Shift shift)
        {
            DateTime nineOclock = shift.StartDate.AddHours(21);
            if (shift.EndDateTime >= nineOclock)
            {
                TimeSpan earlyShiftLength = nineOclock.Subtract(shift.StartDateTime);
                double earlyPay = earlyShiftLength.TotalHours * 21;
                TimeSpan lateShiftLength = shift.EndDateTime.Subtract(nineOclock);
                double latePay = lateShiftLength.TotalHours * 15;
                shift.ShiftPay = earlyPay + latePay;
                return shift;
            }
            else
            {
                TimeSpan shiftLength = shift.EndDateTime.Subtract(shift.StartDateTime);
                shift.ShiftPay = shiftLength.TotalHours * 21;
                return shift;
            }
        }
       
    }
}
