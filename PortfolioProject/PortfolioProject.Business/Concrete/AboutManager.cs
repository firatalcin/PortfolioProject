using PortfolioProject.Business.Abstract;
using PortfolioProject.DataAccess.Abstract;
using PortfolioProject.DataAccess.Concrete.EntityFramework;
using PortfolioProject.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortfolioProject.Business.Concrete
{
    public class AboutManager : IAboutService
    {
        IAboutDal _aboutDal;

        public AboutManager(IAboutDal aboutDal)
        {
            _aboutDal = aboutDal;
        }

        public void Add(About t)
        {
            _aboutDal.Add(t);
        }

        public void Delete(About t)
        {
            _aboutDal.Delete(t);
        }

        public List<About> GetAll()
        {
            return _aboutDal.GetAll();
        }

        public About GetByID(int id)
        {
            return _aboutDal.Get(x => x.Id == id);
        }

        public void Update(About t)
        {
            _aboutDal.Update(t);
        }
    }
}
