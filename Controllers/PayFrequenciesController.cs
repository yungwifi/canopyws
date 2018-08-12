using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace canopyws.Controllers
{
    [Route("api/v1/company/{companyId}/default-tables/pay-frequencies")]
    public class PayFrequenciesController : Controller
    {
        // GET: All api/pay-frequencies
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] {
                                   "Id",
                                   "Name",
                                   "Description",
                                   "GlCode",
                                   "StandardHours",
                                   "PayFrequencyFactor",
                                   "LagValue"
                                  };

        }

        // GET One api/pay-frequencies
        [HttpGet("{frequenciesId}")]
        public IEnumerable<string> Get(string frequenciesId)
        {
            return new string[] {
                                   "Id",
                                   "Name",
                                   "Description",
                                   "GlCode",
                                   "StandardHours",
                                   "PayFrequencyFactor",
                                   "LagValue"
                                  };
        }

    }
}
