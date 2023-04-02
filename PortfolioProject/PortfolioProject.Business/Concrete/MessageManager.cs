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
    public class MessageManager : IGenericService<Message>
    {
        IMessageDal _messageDal;

        public MessageManager(IMessageDal messageDal)
        {
            _messageDal = messageDal;
        }

        public void Add(Message t)
        {
            _messageDal.Add(t);
        }

        public void Delete(Message t)
        {
            _messageDal.Delete(t);
        }

        public List<Message> GetAll()
        {
            return _messageDal.GetAll();
        }

        public Message GetByID(int id)
        {
            return _messageDal.Get(x => x.ID == id);
        }

        public void Update(Message t)
        {
            _messageDal.Update(t);
        }
    }
}
