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
    public class ToDoListManager : IToDoListService
    {
        IToDoListDal _toDoListDal;

        public ToDoListManager(IToDoListDal toDoListDal)
        {
            _toDoListDal = toDoListDal;
        }
        public void Add(ToDoList t)
        {
            throw new NotImplementedException();
        }

        public void Delete(ToDoList t)
        {
            throw new NotImplementedException();
        }

        public List<ToDoList> GetAll()
        {
            return _toDoListDal.GetAll();
        }

        public ToDoList GetByID(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(ToDoList t)
        {
            throw new NotImplementedException();
        }
    }
}
