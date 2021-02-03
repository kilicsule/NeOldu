using Neoldu.Data.Domain.Entities;
using NeOldu.Data.Dal.Abstract;

namespace NeOldu.Data.Dal.Concrete
{
    public interface IDeathDateDal : IEfDal<DeathDate>
    {

    }
    public class DeathDateDal : EfDal<DeathDate>, IDeathDateDal
    {
        public DeathDateDal(NeOlduDbContext context) : base(context)
        {

        }
    }
}
