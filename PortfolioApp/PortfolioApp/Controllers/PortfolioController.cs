using Lib.Core.Model;
using Lib.Services.PortfolioServices;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PortfolioApp.Controllers
{
    public class PortfolioController : Controller
    {
        private readonly IPortfolioServices portfolioServices;

        public PortfolioController(IPortfolioServices portServices)
        {
            portfolioServices = portServices;
        }
        public async Task<IActionResult> List()
        {
            var list = await portfolioServices.GetPortfolioList();
            return View(list);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(Portfolio model)
        {
            if (ModelState.IsValid)
            {
                bool response = await portfolioServices.SavePortfolio(model);

                if (response)
                {
                    return RedirectToAction("List");
                }
            }
            return View(model);
        }
    }
}
