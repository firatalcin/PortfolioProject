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
    public class ContactManager : IGenericService<Contact>
    {
        IContactDal _contactDal;

        public ContactManager(IContactDal contactDal)
        {
            _contactDal = contactDal;
        }

        public void Add(Contact t)
        {
            _contactDal.Add(t);
        }

        public void Delete(Contact t)
        {
            _contactDal.Delete(t);
        }

        public List<Contact> GetAll()
        {
            return _contactDal.GetAll();
        }

        public Contact GetByID(int id)
        {
            return _contactDal.Get(x => x.ID == id);
        }

        public void Update(Contact t)
        {
            _contactDal.Update(t);
        }
    }


}
