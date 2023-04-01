using PortfolioProject.Business.Abstract;
using PortfolioProject.DataAccess.Abstract;
using PortfolioProject.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortfolioProject.Business.Concrete
{
    public class PortfolioManager : IGenericService<Portfolio>
    {
        IPortfolioDal _portfolioDal;

        public PortfolioManager(IPortfolioDal portfolioDal)
        {
            _portfolioDal = portfolioDal;
        }

        public void Add(Portfolio t)
        {
            _portfolioDal.Add(t);
        }

        public void Delete(Portfolio t)
        {
            _portfolioDal.Delete(t);
        }

        public List<Portfolio> GetAll()
        {
            return _portfolioDal.GetAll();  
        }

        public Portfolio GetByID(int id)
        {
            return _portfolioDal.Get(x => x.ID == id);
        }

        public void Update(Portfolio t)
        {
            _portfolioDal.Update(t);
        }
    }
}
