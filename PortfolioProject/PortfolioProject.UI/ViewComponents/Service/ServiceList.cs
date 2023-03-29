using Microsoft.AspNetCore.Mvc;
using PortfolioProject.Business.Concrete;
using PortfolioProject.DataAccess.Concrete.EntityFramework;

namespace PortfolioProject.UI.ViewComponents.Service
{
    public class ServiceList : ViewComponent
    {
        ServiceManager serviceManager = new ServiceManager(new EfServiceDal());
        public IViewComponentResult Invoke()
        {
            var values = serviceManager.GetAll();
            return View(values);
        }
    }
}
