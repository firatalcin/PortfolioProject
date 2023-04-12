using PortfolioProject.Business.Abstract;
using PortfolioProject.DataAccess.Abstract;
using PortfolioProject.Entity.Concrete;

namespace PortfolioProject.Business.Concrete
{
    public class UserMessageManager : IUserMessageService
    {
        IUserMessageDal _userMessageDal;

        public UserMessageManager(IUserMessageDal userMessageDal)
        {
            _userMessageDal = userMessageDal;
        }

        public void Add(UserMessage t)
        {
            throw new NotImplementedException();
        }

        public void Delete(UserMessage t)
        {
            throw new NotImplementedException();
        }

        public List<UserMessage> GetAll()
        {
            return _userMessageDal.GetAll();
        }

        public UserMessage GetByID(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(UserMessage t)
        {
            throw new NotImplementedException();
        }
    }
}
