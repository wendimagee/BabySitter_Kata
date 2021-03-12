using BabySitter_Rate_Calculator.Models;
using System;
using Xunit;

namespace BabySitterTests
{
    public class ShiftTests
    {
        [Theory]
        [InlineData("3/12/2021 5:00:00 PM", "3/12/2021 8:00:00 PM", 45)]
        [InlineData("3/12/2021 7:00:00 PM", "3/12/2021 1:00:00 AM", 100)]
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
    }
}
