using Microsoft.AspNetCore.Mvc;
using PortfolioProject.DataAccess.Concrete.Context;

namespace PortfolioProject.UI.ViewComponents.Dashboard
{
    public class FeatureStatistics : ViewComponent
    {
        ApplicationContext context = new ApplicationContext();

        public IViewComponentResult Invoke()
        {
            ViewBag.v1 = context.Skills.Count();
            ViewBag.v2 = context.Messages.Where(x => x.Status == false).Count();
            ViewBag.v3 = context.Messages.Where(x => x.Status == true).Count();
            ViewBag.v4 = context.Experiences.Count();
            return View();
        }
    }
}
