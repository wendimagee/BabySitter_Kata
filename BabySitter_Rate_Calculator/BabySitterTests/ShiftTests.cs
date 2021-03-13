using BabySitter_Rate_Calculator.Models;
using System;
using Xunit;

namespace BabySitterTests
{
    public class ShiftTests
    {
        //[Theory]
        //[InlineData("3/12/2021 5:00:00 PM", "3/12/2021 8:00:00 PM", 45)]
        //[InlineData("3/12/2021 7:00:00 PM", "3/13/2021 1:00:00 AM", 100)]
        //public void ShouldCalculateTotalAmountForHoursWorked(string start, string end, double expected)
        //{
        //    // Arrange
        //    var startTime = DateTime.Parse(start);
        //    var endTime = DateTime.Parse(end);

        //    var shift = new Shift();
        //    shift.StartDateTime = startTime;
        //    shift.EndDateTime = endTime;

        //    // Act
        //    shift.ShiftPay = shift.Calculate(shift);
        //    double actual = shift.ShiftPay;

        //    // Assert
        //    Assert.Equal(expected, actual);
        //}

        //[Theory]
        //[InlineData("3/12/2021 5:00:00 PM", "3/12/2021 8:00:00 PM", "familyA", 45)]
        //[InlineData("3/12/2021 5:00:00 PM", "3/12/2021 8:00:00 PM", "familyB", 36)]
        //[InlineData("3/12/2021 10:00:00 PM", "3/13/2021 12:00:00 AM", "familyB", 16)]
        //[InlineData("3/12/2021 10:00:00 PM", "3/13/2021 3:00:00 AM", "familyB", 76)]
        //[InlineData("3/12/2021 05:00:00 PM", "3/12/2021 8:00:00 PM", "familyC", 63)]
        //[InlineData("3/12/2021 07:00:00 PM", "3/12/2021 11:00:00 PM", "familyC", 72)]
        //public void ShouldCalculateTotalAmountofHoursWorked(string start, string end, string family, double expected)
        //{
        //    // Arrange
        //    var startTime = DateTime.Parse(start);
        //    var endTime = DateTime.Parse(end);

        //    var shift = new Shift();
        //    shift.StartDateTime = startTime;
        //    shift.EndDateTime = endTime;
        //    shift.ShiftFamily = family;
        //    // Act
        //    double actual = 10;
        //    if(shift.ShiftFamily == "familyA")
        //    {
        //        shift.ShiftPay = shift.Calculate(shift);
        //        actual = shift.ShiftPay;
        //    }
        //    else if(shift.ShiftFamily == "familyB")
        //    {
        //        shift.ShiftPay = shift.CalculateB(shift);
        //        actual = shift.ShiftPay;
        //    }
        //    else if(shift.ShiftFamily == "familyC")
        //    {
        //        shift.ShiftPay = shift.CalculateC(shift);
        //        actual = shift.ShiftPay;
        //    }

        //    // Assert
        //    Assert.Equal(expected, actual);
        //}

        [Theory]
        [InlineData( "5:00:00 PM", "3/12/2021 12:00:00 AM", "8:00:00 PM", "3/12/2021 12:00:00 AM", "familyA", 45)]

        public void ShouldTestModelMakingandRate(DateTime startTime, DateTime startDate, DateTime endTime, DateTime endDate, string shiftFamily, double expected)
        {
            Shift shift = new Shift();
            shift.StartTime = startTime.TimeOfDay;
            shift.EndTime = endTime.TimeOfDay;
            shift.StartDate = startDate;
            shift.EndDate = endDate;
            shift.ShiftFamily = shiftFamily;

            shift.ShiftPay = shift.Calculate(shift);
            double actual = shift.ShiftPay;
            Assert.Equal(expected, actual);
        }
    }
}
