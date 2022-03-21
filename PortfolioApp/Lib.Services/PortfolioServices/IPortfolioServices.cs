using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Lib.Core.Model;

namespace Lib.Services.PortfolioServices
{
    public interface IPortfolioServices
    {
        Task<List<Portfolio>> GetPortfolioList();

        Task<bool> SavePortfolio(Portfolio model);
    }
}
