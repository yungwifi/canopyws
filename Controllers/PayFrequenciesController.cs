using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using canopyws.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace canopyws.Controllers
{
    [Route("api/v1/company/{companyId}/default-tables/pay-frequencies")]
    public class PayFrequenciesController : Controller
    {
        // GET: All api/pay-frequencies
        //creating a pay frequency object just for front end purposes. 

        [HttpGet]
        public IActionResult Index()
        {
            var payFreq = new PayFrequencyModel() {
                Id= 334916,
                Name= "10",
                Description = "10 Month",
                GlCode = "",
                StandardHours = 80,
                PayFrequencyFactor = 1950,
                LagValue = "0" };

            return View(payFreq);
        }

        // GET One api/pay-frequencies
        //set this get request up in hopes to be able to use it for the search functionality in the future also 

        [HttpGet("{frequenciesId}")]
        public IActionResult Show()
        {
            var payFreq = new PayFrequencyModel()
            {
                Id = 334916,
                Name = "10",
                Description = "10 Month",
                GlCode = "",
                StandardHours = 80,
                PayFrequencyFactor = 1950,
                LagValue = "0"
            };

            return View(payFreq);
        }

    }
}
