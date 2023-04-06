using Microsoft.AspNetCore.Mvc;
using PortfolioProject.Business.Concrete;
using PortfolioProject.DataAccess.Concrete.EntityFramework;
using PortfolioProject.Entity.Concrete;

namespace PortfolioProject.UI.Controllers
{
    public class ExperienceController : Controller
    {
        ExperienceManager experienceManager = new ExperienceManager(new EfExperienceDal());

        public IActionResult Index()
        {
            var values = experienceManager.GetAll();
            return View(values);
        }

        [HttpGet]
        public IActionResult AddExperience() 
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddExperience(Experience experience) 
        {
            experienceManager.Add(experience);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult EditExperience(int id) 
        {
            var entity = experienceManager.GetByID(id);
            return View(entity);   
        }

        [HttpPost]
        public IActionResult EditExperience(Experience experience)
        {
            experienceManager.Update(experience);
            return RedirectToAction("Index");
        }

        public IActionResult DeleteExperience(int id)
        {
            var entity = experienceManager.GetByID(id);
            experienceManager.Delete(entity);
            return RedirectToAction("Index");
        }
    }
}
