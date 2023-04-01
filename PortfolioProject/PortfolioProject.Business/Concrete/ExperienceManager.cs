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
    public class ExperienceManager : IGenericService<Experience>
    {
        IExperienceDal _experienceDal;

        public ExperienceManager(IExperienceDal experienceDal)
        {
            _experienceDal = experienceDal;
        }

        public void Add(Experience t)
        {
            _experienceDal.Add(t);
        }

        public void Delete(Experience t)
        {
            _experienceDal.Delete(t);
        }

        public List<Experience> GetAll()
        {
            return _experienceDal.GetAll();
        }

        public Experience GetByID(int id)
        {
            return _experienceDal.Get(x => x.ID == id);
        }

        public void Update(Experience t)
        {
            _experienceDal.Update(t);   
        }
    }
}
