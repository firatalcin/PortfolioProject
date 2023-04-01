using Microsoft.AspNetCore.Mvc;

namespace PortfolioProject.UI.ViewComponents.Contact
{
    public class SendMessage : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
