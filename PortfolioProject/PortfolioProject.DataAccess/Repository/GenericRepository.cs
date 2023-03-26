using PortfolioProject.DataAccess.Abstract;
using PortfolioProject.DataAccess.Concrete.Context;
using System.Linq.Expressions;

namespace PortfolioProject.DataAccess.Repository
{
    public class GenericRepository<T> : IGenericDal<T> where T : class
    {
        public void Add(T t)
        {
            using (ApplicationContext context = new ApplicationContext())
            {
                context.Add(t);
                context.SaveChanges();
            }
        }

        public void Delete(T t)
        {
            using (ApplicationContext context = new ApplicationContext())
            {
                context.Remove(t);
                context.SaveChanges();
            }
        }

        public T Get(Expression<Func<T, bool>> filter)
        {
            using (ApplicationContext context = new ApplicationContext())
            {
               return context.Set<T>().Where(filter).FirstOrDefault();
            }
        }

        public List<T> GetAll(Expression<Func<T, bool>> filter = null)
        {
            using (ApplicationContext context = new ApplicationContext())
            {
               return filter == null ? 
                context.Set<T>().ToList() :    
                context.Set<T>().Where(filter).ToList();
            }
        }

        public void Update(T t)
        {
            using (ApplicationContext context = new ApplicationContext())
            {
                context.Update(t);
                context.SaveChanges();
            }
        }
    }
}
