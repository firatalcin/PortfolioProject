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
    public class ServiceManager : IGenericService<Service>
    {
        IServiceDal serviceDal;

        public ServiceManager(IServiceDal serviceDal)
        {
            this.serviceDal = serviceDal;
        }

        public void Add(Service t)
        {
            serviceDal.Add(t);
        }

        public void Delete(Service t)
        {
            serviceDal.Delete(t);
        }

        public List<Service> GetAll()
        {
            return serviceDal.GetAll();
        }

        public Service GetByID(int id)
        {
            return serviceDal.Get(x => x.Id == id);
        }

        public void Update(Service t)
        {
            serviceDal.Update(t);
        }
    }
}
