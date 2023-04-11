using Microsoft.AspNetCore.Mvc;
using PortfolioProject.Business.Concrete;
using PortfolioProject.DataAccess.Concrete.EntityFramework;

namespace PortfolioProject.UI.ViewComponents.Dashboard
{
    public class ProjectList : ViewComponent
    {
        PortfolioManager portfolioManager = new PortfolioManager(new EfPortfolioDal());
        public IViewComponentResult Invoke()
        {
            var values = portfolioManager.GetAll();
            return View(values);
        }
    }
}
