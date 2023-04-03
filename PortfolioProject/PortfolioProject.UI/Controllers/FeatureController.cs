using Microsoft.AspNetCore.Mvc;

namespace PortfolioProject.UI.Controllers
{
    public class FeatureController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
