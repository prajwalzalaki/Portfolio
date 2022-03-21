using Microsoft.AspNetCore.Mvc;
using Portfolio_API.IServices;
using Portfolio_API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Portfolio_API.Controllers
{
    public class PortfolioController : ControllerBase
    {
        private readonly IPortfolioServices portfolioService;
        public PortfolioController(IPortfolioServices portfolio)
        {
            portfolioService = portfolio;
        }
        [HttpGet]
        [Route("[action]")]
        [Route("api/Portfolio/GetPortfolio")]
        public IEnumerable<Portfolio> GetPortfolio()
        {
            return portfolioService.GetPortfolio();
        }
        [HttpPost]
        [Route("[action]")]
        [Route("api/Portfolio/AddPortfolio")]
        public Portfolio AddPortfolio(Portfolio port)
        {
            return portfolioService.AddPortfolio(port);
        }
        [HttpPut]
        [Route("[action]")]
        [Route("api/Portfolio/EditPortfolio")]
        public Portfolio EditPortfolio(Portfolio port)
        {
            return portfolioService.EditPortfolio(port);
        }
        [HttpDelete]
        [Route("[action]")]
        [Route("api/Portfolio/DeletePortfolio")]
        public Portfolio DeletePortfolio(int id)
        {
            return portfolioService.DeletePortfolio(id);
        }
    }
}

