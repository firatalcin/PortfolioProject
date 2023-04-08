using Microsoft.AspNetCore.Mvc;
using PortfolioProject.Business.Concrete;
using PortfolioProject.DataAccess.Concrete.EntityFramework;
using PortfolioProject.Entity.Concrete;

namespace PortfolioProject.UI.Controllers
{
    public class ServiceController : Controller
    {
        ServiceManager serviceManager = new ServiceManager(new EfServiceDal());

        public IActionResult Index()
        {
            var values = serviceManager.GetAll();
            return View(values);
        }

        [HttpGet]
        public IActionResult AddService()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddService(Service service)
        {
            serviceManager.Add(service);
            return RedirectToAction("Index");
        }
        public IActionResult DeleteService(int id)
        {
            var values = serviceManager.GetByID(id);
            serviceManager.Delete(values);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult EditService(int id)
        {
            var values = serviceManager.GetByID(id);
            return View(values);
        }
        [HttpPost]
        public IActionResult EditService(Service service)
        {
            serviceManager.Update(service);
            return RedirectToAction("Index");
        }
    }
}
