using Microsoft.AspNetCore.Mvc;
using PortfolioProject.Business.Concrete;
using PortfolioProject.DataAccess.Concrete.EntityFramework;

namespace PortfolioProject.UI.ViewComponents.Contact
{
    public class ContactDetail : ViewComponent
    {
        ContactManager contactManager = new ContactManager(new EfContactDal());

        public IViewComponentResult Invoke()
        {
            var contacts = contactManager.GetAll();
            return View(contacts);
        }
    }
}
