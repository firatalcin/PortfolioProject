using Microsoft.AspNetCore.Mvc;

namespace PortfolioProject.UI.ViewComponents.Contact
{
    public class ContactDetail : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
