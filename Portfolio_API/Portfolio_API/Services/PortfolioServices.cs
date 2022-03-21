using Portfolio_API.IServices;
using Portfolio_API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Portfolio_API.Services
{
    public class PortfolioServices:IPortfolioServices
    {
        PORTFOLIODBIContext dbcontext;
        public PortfolioServices(PORTFOLIODBIContext db)
        {
            dbcontext = db;
        }
        public Portfolio AddPortfolio(Portfolio port)
        {
            dbcontext.Portfolio.Add(port);
            dbcontext.SaveChanges();
            return port;
        }

        public Portfolio DeletePortfolio(int id)
        {
            var port = dbcontext.Portfolio.Find(id);
            dbcontext.Portfolio.Remove(port);
            dbcontext.SaveChanges();
            return port;
        }


        public Portfolio EditPortfolio(Portfolio port)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Portfolio> GetPortfolio()
        {
            return dbcontext.Portfolio.ToList();
        }

        public Portfolio UpdatePortfolio(Portfolio portfolio)
        {
            dbcontext.Entry(portfolio).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            dbcontext.SaveChanges();
            return portfolio;
        }
    }
}
