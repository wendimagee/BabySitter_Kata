using BabySitter_Rate_Calculator.Models;
using System;
using Xunit;

namespace BabySitterTests
{
    public class ShiftTests
    {
        [Theory]
        [InlineData("3/12/2021 5:00:00 PM", "3/12/2021 8:00:00 PM")]
        public void ShouldCalculateTotalAmountForHoursWorked(string start, string end)
        {
            // Arrange
            double expected = 45;

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
