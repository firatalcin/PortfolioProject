using Microsoft.AspNetCore.Mvc;
using PortfolioProject.DataAccess.Concrete.Context;

namespace PortfolioProject.UI.ViewComponents.Dashboard
{
    public class StatisticsDashboard2 : ViewComponent
    {
        ApplicationContext c = new ApplicationContext();
        public IViewComponentResult Invoke()
        {
            ViewBag.v1 = c.Portfolios.Count();
            ViewBag.v2 = c.Messages.Count();
            ViewBag.v3 = c.Services.Count();
            return View();
        }
    }
}
