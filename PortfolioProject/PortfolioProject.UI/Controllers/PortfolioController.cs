using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;
using PortfolioProject.Business.Concrete;
using PortfolioProject.Business.ValidationRules;
using PortfolioProject.DataAccess.Concrete.EntityFramework;
using PortfolioProject.Entity.Concrete;

namespace PortfolioProject.UI.Controllers
{
    public class PortfolioController : Controller
    {
        PortfolioManager portfolioManager = new PortfolioManager(new EfPortfolioDal());

        public IActionResult Index()
        {
            var values = portfolioManager.GetAll();
            return View(values);
        }

        [HttpGet]
        public IActionResult AddPortfolio() 
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddPortfolio(Portfolio portfolio)
        {
            PortfolioValidator validations= new PortfolioValidator();
            ValidationResult results = validations.Validate(portfolio);
            if (results.IsValid)
            {
                portfolioManager.Add(portfolio);
                return RedirectToAction("Index");
            }
            else
            {
                foreach (var item in results.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }

            return View();


        }

        [HttpGet]
        public IActionResult EditPortfolio(int id)
        {
            var entity = portfolioManager.GetByID(id);
            return View(entity);
        }

        [HttpPost]
        public IActionResult EditPortfolio(Portfolio portfolio)
        {
            PortfolioValidator validations = new PortfolioValidator();
            ValidationResult result= validations.Validate(portfolio);
            if (result.IsValid)
            {
                portfolioManager.Update(portfolio);
                return RedirectToAction("Index");
            }
            else
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
                return View();
            }
        }

        public IActionResult DeletePortfolio(int id)
        {
            var entity = portfolioManager.GetByID(id);
            portfolioManager.Delete(entity);
            return RedirectToAction("Index");
        }
    }
}
