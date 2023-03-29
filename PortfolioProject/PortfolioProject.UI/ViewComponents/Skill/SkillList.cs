using Microsoft.AspNetCore.Mvc;
using PortfolioProject.Business.Concrete;
using PortfolioProject.DataAccess.Concrete.EntityFramework;

namespace PortfolioProject.UI.ViewComponents.Skill
{
    public class SkillList : ViewComponent
    {
        SkillManager skillManager = new SkillManager(new EfSkillDal());
        public IViewComponentResult Invoke()
        {
            var values = skillManager.GetAll();
            return View(values);
        }
    }
}
