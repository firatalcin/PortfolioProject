using Microsoft.AspNetCore.Mvc;

namespace PortfolioProject.UI.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
