using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Lib.Core.Model;
using Newtonsoft.Json;

namespace Lib.Services.PortfolioServices
{
    public class PortfolioServices:IPortfolioServices
    {
        public PortfolioServices()
        {
        }

        public async Task<List<Portfolio>> GetPortfolioList()
        {
            var portfoliolist = new List<Portfolio>();

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:44325/");
                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                var response = await client.GetAsync("api/Portfolio/GetPortfolio");
                if (response.IsSuccessStatusCode)
                {
                    var readTask = response.Content.ReadAsStringAsync().Result;
                    portfoliolist = JsonConvert.DeserializeObject<List<Portfolio>>(readTask);

                    return portfoliolist;
                }
                return portfoliolist;
            }

        }

        public async Task<bool> SavePortfolio(Portfolio model)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:44325/");
                client.DefaultRequestHeaders.Clear();
                string jsonData = JsonConvert.SerializeObject(model);
                var content = new StringContent(jsonData, UnicodeEncoding.UTF8, "application/json");
                var response = await client.PostAsync("api/Portfolio/AddPortfolio", content);

                if (response.IsSuccessStatusCode)
                {
                    var readTask = response.Content.ReadAsStringAsync().Result;
                    var result = JsonConvert.DeserializeObject<bool>(readTask);

                    return result;

                }
            }
            return false;
        }
    }
}
