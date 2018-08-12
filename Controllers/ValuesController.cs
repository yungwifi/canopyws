using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace canopyws.Controllers
{
    [Route("api/values")]
    public class ValuesController : Controller
    {
        // GET: api/values
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

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

    }
}
