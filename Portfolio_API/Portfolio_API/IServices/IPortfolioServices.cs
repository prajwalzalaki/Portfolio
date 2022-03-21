using Portfolio_API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Portfolio_API.IServices
{
    public interface IPortfolioServices
    {
        IEnumerable<Portfolio> GetPortfolio();
        Portfolio AddPortfolio(Portfolio port);
        Portfolio EditPortfolio(Portfolio port);
        Portfolio DeletePortfolio(int id);
    }
}
