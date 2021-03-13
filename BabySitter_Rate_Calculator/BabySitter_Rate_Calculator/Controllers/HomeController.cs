using BabySitter_Rate_Calculator.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace BabySitter_Rate_Calculator.Controllers
{
    public class HomeController : Controller
    {
        Shift shift = new Shift();
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Calculate(Shift shift)
        {
            try
            {
                if (shift.ShiftFamily == "familyA")
                {
                    Shift shifted = new Shift();
                    shifted = shift.Calculate(shift);
                    TimeSpan hoursOfShift = shifted.EndDateTime.Subtract(shifted.StartDateTime);
                    TimeSpan elevenHours = TimeSpan.Parse("0.11:00");
                    if (hoursOfShift > elevenHours)
                    {
                        throw new Exception();
                    }
                    else
                    {
                        return View(shifted);
                    }
                }
                else if (shift.ShiftFamily == "familyB")
                {
                    Shift shifted = new Shift();
                    shifted = shift.CalculateB(shift);
                    TimeSpan hoursOfShift = shifted.EndDateTime.Subtract(shifted.StartDateTime);
                    TimeSpan elevenHours = TimeSpan.Parse("0.11:00");
                    if (hoursOfShift > elevenHours)
                    {
                        throw new Exception();
                    }
                    else
                    {
                        return View(shifted);
                    }
                }
                else
                {
                    Shift shifted = new Shift();
                    shifted = shift.CalculateC(shift);
                    TimeSpan hoursOfShift = shifted.EndDateTime.Subtract(shifted.StartDateTime);
                    TimeSpan elevenHours = TimeSpan.Parse("0.11:00");
                    if (hoursOfShift > elevenHours)
                    {
                        throw new Exception();
                    }
                    else
                    {
                        return View(shifted);
                    }
                }
            }
            catch
            {
                return View("ShiftLengthError");
            }
            
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
