using Microsoft.EntityFrameworkCore;
using PortfolioProject.DataAccess.Abstract;
using PortfolioProject.DataAccess.Concrete.Context;
using PortfolioProject.DataAccess.Repository;
using PortfolioProject.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortfolioProject.DataAccess.Concrete.EntityFramework
{
    public class EfUserMessageDal : GenericRepository<UserMessage>, IUserMessageDal
    {
        public List<UserMessage> GetUserMessagesWithUser()
        {
            using (var c = new ApplicationContext())
            {
                return c.UserMessages.Include(x => x.User).ToList();
            }
        }
    }
}
