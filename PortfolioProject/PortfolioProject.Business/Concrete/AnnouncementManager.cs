using PortfolioProject.Business.Abstract;
using PortfolioProject.DataAccess.Abstract;
using PortfolioProject.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortfolioProject.Business.Concrete
{
    public class AnnouncementManager : IAnnouncementService
    {
        IAnnouncementDal _announcementDal;

        public AnnouncementManager(IAnnouncementDal announcementDal)
        {
            _announcementDal = announcementDal;
        }

        public void Add(Announcement t)
        {
            throw new NotImplementedException();
        }

        public void Delete(Announcement t)
        {
            throw new NotImplementedException();
        }

        public List<Announcement> GetAll()
        {
            return _announcementDal.GetAll();
        }

        public Announcement GetByID(int id)
        {
            return _announcementDal.Get(x => x.Id.Equals(id));
        }

        public void Update(Announcement t)
        {
            throw new NotImplementedException();
        }
    }
}
