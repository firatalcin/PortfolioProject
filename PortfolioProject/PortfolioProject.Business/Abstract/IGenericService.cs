using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortfolioProject.Business.Abstract
{
    public interface IGenericService<T> where T : class
    {
        void Add();
        void Delete();
        void Update();
        List<T> GetAll();
        T GetByID(int id);
    }
}
