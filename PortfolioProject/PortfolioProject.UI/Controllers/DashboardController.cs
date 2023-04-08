using Microsoft.AspNetCore.Mvc;

namespace PortfolioProject.UI.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
