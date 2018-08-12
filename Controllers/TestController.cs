using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Net.Http;
using canopyws.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace canopyws.Controllers
{
    public class TestController : Controller
    {
        private static readonly HttpClient client = new HttpClient();

        // GET: /<controller>/
        public JsonResult Index()
        {
            var responseString = client.GetStringAsync("https://api.webhris.com/v1/company/236/exports");
            return Json(responseString);
        }
    }
}
