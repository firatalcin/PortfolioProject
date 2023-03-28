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
    public class FeatureManager : IGenericService<Feature>
    {
        IFeatureDal featureDal;

        public FeatureManager(IFeatureDal featureDal)
        {
            this.featureDal = featureDal;
        }

        public void Add(Feature t)
        {
            featureDal.Add(t);
        }

        public void Delete(Feature t)
        {
            featureDal.Delete(t);   
        }

        public List<Feature> GetAll()
        {
            return featureDal.GetAll();
        }

        public Feature GetByID(int id)
        {
            return featureDal.Get(x => x.Id == id);
        }

        public void Update(Feature t)
        {
            featureDal.Update(t);
        }
    }
}
