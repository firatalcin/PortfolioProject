using PortfolioProject.DataAccess.Abstract;
using PortfolioProject.DataAccess.Repository;
using PortfolioProject.Entity.Concrete;

namespace PortfolioProject.DataAccess.Concrete.EntityFramework
{
    public class EfSkillDal : GenericRepository<Skill>, ISkillDal
    {

    }


}
