using System.Linq.Expressions;

namespace PortfolioProject.DataAccess.Abstract
{
    public interface IGenericDal<T> where T : class
    {
        void Add(T t);
        void Update(T t);
        void Delete(T t);
        List<T> GetAll(Expression<Func<T, bool>> filter=null);
        T Get(Expression<Func<T, bool>> filter);
    }
}
