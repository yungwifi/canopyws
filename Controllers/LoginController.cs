using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using canopyws.Models;
using System.Net.Http;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace canopyws.Controllers
{
    [Route("api/auth")]
    public class LoginController : Controller
    {
        private static readonly HttpClient client = new HttpClient();

        // POST api
        //Making a post with the parameters to login to the API Dont know what to do with the bearer token or where to put it 
        [HttpPost]
        public async void Post([FromBody]string value)
        {
            var values = new Dictionary<string, string>
                {
                { "username", "CodeChallengeApiUser" },
                { "password", "CpLk0UMcy^G3ZU#T8*J#@YfLTZyTZnzWi4@U1ELn^3" },
                { "grant_type", "password" }
                };

            var content = new FormUrlEncodedContent(values);

            var response = await client.PostAsync("https://api.webhris.com/auth/token/", content);

            var responseString = await response.Content.ReadAsStringAsync();
        }

    }
}
