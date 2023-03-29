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
    public class SkillManager : IGenericService<Skill>
    {
        ISkillDal _skillDal;

        public SkillManager(ISkillDal skillDal)
        {
            _skillDal = skillDal;
        }

        public void Add(Skill t)
        {
            _skillDal.Add(t);
        }

        public void Delete(Skill t)
        {
            _skillDal.Delete(t);    
        }

        public List<Skill> GetAll()
        {
           return  _skillDal.GetAll();
        }

        public Skill GetByID(int id)
        {
            return _skillDal.Get(x => x.ID == id);
        }

        public void Update(Skill t)
        {
            _skillDal.Update(t);
        }
    }
}
