using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;
using canopyws.Models;

namespace canopyws.Controllers
{
    public class NewHttpClientInstancePerRequestController : APIController
    {
        private static readonly HttpClient httpClient;

        static NewHttpClientInstancePerRequestController()
        {
            HttpClient = new HttpClient();
        }

        // This method uses the shared instance of HttpClient for every call to GetProductAsync.
        public async Task<EmployeeModel> GetLoginAsync(string json)
        {
            var values = new Dictionary<string, string>
            {
                { "username", "CodeChallengeApiUser" },
                { "password", "CpLk0UMcy^G3ZU#T8*J#@YfLTZyTZnzWi4@U1ELn^3" },
                { "grant_type", "password"}
            };

            var content = new FormUrlEncodedContent(values);
            var response = await HttpClient.PostAsync("https://api.webhris.com/auth/token", content);
            var responseString = await response.Content.ReadAsStringAsync();
        }
        
    }
}
