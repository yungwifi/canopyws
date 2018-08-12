using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using canopyws.Models;
using System.Net.Http;

namespace canopyws.Controllers
{
    public class EmployeeController : Controller
    {
        public string Index()
        {
            return "This is the employee Index";
        }

        public IActionResult Employee()
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
