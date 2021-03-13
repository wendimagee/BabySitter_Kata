using BabySitter_Rate_Calculator.Models;
using System;
using Xunit;

namespace BabySitterTests
{
    public class ShiftTests
    {
        [Theory]
        [InlineData("3/12/2021 5:00:00 PM", "3/12/2021 8:00:00 PM", 45)]
        [InlineData("3/12/2021 7:00:00 PM", "3/13/2021 1:00:00 AM", 100)]
        public void ShouldCalculateTotalAmountForHoursWorked(string start, string end, double expected)
        {
            // Arrange
            var startTime = DateTime.Parse(start);
            var endTime = DateTime.Parse(end);

            var shift = new Shift();
            shift.StartTime = startTime;
            shift.EndTime = endTime;

            // Act
            shift.ShiftPay = shift.Calculate(shift);
            double actual = shift.ShiftPay;

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("3/12/2021 5:00:00 PM", "3/12/2021 8:00:00 PM", "familyA", 45)]
        [InlineData("3/12/2021 5:00:00 PM", "3/12/2021 8:00:00 PM", "familyB", 36)]
        [InlineData("3/12/2021 10:00:00 PM", "3/13/2021 12:00:00 AM", "familyB", 16)]
        public void ShouldCalculateTotalAmountofHoursWorked(string start, string end, string family, double expected)
        {
            // Arrange
            var startTime = DateTime.Parse(start);
            var endTime = DateTime.Parse(end);

            var shift = new Shift();
            shift.StartTime = startTime;
            shift.EndTime = endTime;
            shift.ShiftFamily = family;
            // Act
            double actual;
            if(shift.ShiftFamily == "familyA")
            {
                shift.ShiftPay = shift.Calculate(shift);
                actual = shift.ShiftPay;
            }
            else if(shift.ShiftFamily == "familyB")
            {
                shift.ShiftPay = shift.CalculateB(shift);
                actual = shift.ShiftPay;
            }
            else
            {
                actual = 30;
            }

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}
