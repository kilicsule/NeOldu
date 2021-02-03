using Neoldu.Data.Domain.Entities;
using NeOldu.Data.Dal.Abstract;

namespace NeOldu.Data.Dal.Concrete
{
    public interface IPeopleDal : IEfDal<People>
    {

    }
    public class PeopleDal : EfDal<People>, IPeopleDal
    {
        public PeopleDal(NeOlduDbContext context) : base(context)
        {

        }
    }
}
