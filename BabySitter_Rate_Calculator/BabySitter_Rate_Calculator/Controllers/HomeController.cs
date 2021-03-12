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
            Shift shifted = new Shift();
            shifted.ShiftPay = shift.Calculate(shift);
            return View(shifted);
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
