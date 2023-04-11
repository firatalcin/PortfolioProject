﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortfolioProject.Entity.Concrete
{
    public class UserMessage
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime Date { get; set; }
        public bool Status { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
    }
}
