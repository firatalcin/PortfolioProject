using Microsoft.AspNetCore.Mvc;
using PortfolioProject.UI.Areas.Writer.Models;

namespace PortfolioProject.UI.Areas.Writer.Controllers
{
    [Area("Writer")]
    public class RegisterController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(UserRegisterViewModel p)
        {
            if (ModelState.IsValid)
            {

            }
            return View();
        }
    }
}
