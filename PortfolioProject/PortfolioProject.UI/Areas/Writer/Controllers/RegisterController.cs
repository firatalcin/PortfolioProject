using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using PortfolioProject.Entity.Concrete;
using PortfolioProject.UI.Areas.Writer.Models;

namespace PortfolioProject.UI.Areas.Writer.Controllers
{
    [Area("Writer")]
    public class RegisterController : Controller
    {
        private readonly UserManager<WriterUser> _userManager;

        public RegisterController(UserManager<WriterUser> userManager)
        {
            _userManager = userManager;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(UserRegisterViewModel p)
        {
            if (ModelState.IsValid)
            {
                WriterUser w = new WriterUser()
                {
                    Name = p.Name,
                    Surname = p.Surname,
                    UserName = p.UserName,
                    Email = p.Mail,
                    ImageUrl = p.ImageUrl
                };

                var result = await _userManager.CreateAsync(w, p.Password);

                if (result.Succeeded) {
                    return RedirectToAction("Index", "Login");
                }
                else
                {
                    foreach (var item in result.Errors)
                    {
                        ModelState.AddModelError("", item.Description);        
                    }
                }
            }
            return View();
        }
    }
}
