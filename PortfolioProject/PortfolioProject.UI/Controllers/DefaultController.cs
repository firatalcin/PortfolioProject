using Microsoft.AspNetCore.Mvc;
using PortfolioProject.Business.Concrete;
using PortfolioProject.DataAccess.Concrete.EntityFramework;
using PortfolioProject.Entity.Concrete;

namespace PortfolioProject.UI.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public PartialViewResult HeaderPartial()
        {
            return PartialView();
        }

        public PartialViewResult NavbarPartial()
        {
            return PartialView();
        }

        [HttpGet]
        public PartialViewResult SendMessagePartial() 
        {
            return PartialView();
        }

        [HttpPost]
        public PartialViewResult SendMessagePartial(Message message)
        {
            MessageManager messageManager = new MessageManager(new EfMessageDal());
            message.Date = Convert.ToDateTime(DateTime.Now.ToShortDateString());
            message.Status = true;
            messageManager.Add(message);
            return PartialView("Index");
        }
    }
}
