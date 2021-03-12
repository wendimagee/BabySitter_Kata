using BabySitter_Rate_Calculator.Models;
using System;
using Xunit;

namespace BabySitterTests
{
    public class ShiftTests
    {
        [Fact]
        public void ShouldCalculateTotalAmountForHoursWorked()
        {
            // Arrange
            double expected = 45;

            var startTime = DateTime.Parse("3/12/2021 5:00:00 PM");
            var endTime = DateTime.Parse("3/12/2021 8:00:00 PM");

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
