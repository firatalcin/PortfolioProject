﻿using PortfolioProject.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortfolioProject.DataAccess.Abstract
{
    public interface IUserMessageDal : IGenericDal<UserMessage>
    {
        public List<UserMessage> GetUserMessagesWithUser();
    }
}
