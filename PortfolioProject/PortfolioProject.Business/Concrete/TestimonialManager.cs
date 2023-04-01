using PortfolioProject.Business.Abstract;
using PortfolioProject.DataAccess.Abstract;
using PortfolioProject.Entity.Concrete;

namespace PortfolioProject.Business.Concrete
{
    public class TestimonialManager : IGenericService<Testimonial>
    {
        ITestimonialDal _testimonialDal;

        public TestimonialManager(ITestimonialDal testimonialDal)
        {
            _testimonialDal = testimonialDal;
        }

        public void Add(Testimonial t)
        {
            _testimonialDal.Add(t);
        }

        public void Delete(Testimonial t)
        {
            _testimonialDal.Delete(t);
        }

        public List<Testimonial> GetAll()
        {
            return _testimonialDal.GetAll();
        }

        public Testimonial GetByID(int id)
        {
            return _testimonialDal.Get(x => x.ID.Equals(id));
        }

        public void Update(Testimonial t)
        {
            _testimonialDal.Update(t);
        }
    }
}
