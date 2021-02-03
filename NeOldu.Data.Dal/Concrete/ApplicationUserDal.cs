using Neoldu.Data.Domain.Entities;
using NeOldu.Data.Dal.Abstract;

namespace NeOldu.Data.Dal.Concrete
{
    public interface IApplicationUserDal : IEfDal<ApplicationUser>
    {

    }
    public class ApplicationUserDal : EfDal<ApplicationUser>, IApplicationUserDal
    {
        public ApplicationUserDal(NeOlduDbContext context) : base(context)
        {

        }
    }
}
