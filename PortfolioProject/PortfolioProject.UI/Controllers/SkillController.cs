using Microsoft.AspNetCore.Mvc;
using PortfolioProject.Business.Concrete;
using PortfolioProject.DataAccess.Concrete.EntityFramework;
using PortfolioProject.Entity.Concrete;

namespace PortfolioProject.UI.Controllers
{
    public class SkillController : Controller
    {
        SkillManager skillManager = new SkillManager(new EfSkillDal());
        public IActionResult Index()
        {
            var values = skillManager.GetAll();
            return View();
        }

        [HttpGet]
        public IActionResult AddSkill()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddSkill(Skill skill)
        {
            skillManager.Add(skill);
            return RedirectToAction("Index");
        }

        public IActionResult DeleteSkill(int id) 
        {
            var entity = skillManager.GetByID(id);
            skillManager.Delete(entity);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult EditSkill(int id)
        {
            var entity = skillManager.GetByID(id);
            return View(entity);
        }

        [HttpPost]
        public IActionResult EditSkill(Skill skill)
        {
            skillManager.Update(skill);
            return RedirectToAction("Index");
        }
    }
}
