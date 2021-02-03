using Neoldu.Data.Domain.Entities;
using NeOldu.Data.Dal.Abstract;

namespace NeOldu.Data.Dal.Concrete
{
    public interface IApplicationTypeDal : IEfDal<ApplicationType>
    {

    }
    public class ApplicationTypeDal : EfDal<ApplicationType>, IApplicationTypeDal
    {
        public ApplicationTypeDal(NeOlduDbContext context) : base(context)
        {

        }
    }
}
