using Neoldu.Data.Domain.Entities;
using NeOldu.Data.Dal.Abstract;

namespace NeOldu.Data.Dal.Concrete
{
    public interface IApplicationUserCommentDal : IEfDal<ApplicationUserComment>
    {

    }
    public class ApplicationUserCommentDal : EfDal<ApplicationUserComment>, IApplicationUserCommentDal
    {
        public ApplicationUserCommentDal(NeOlduDbContext context) : base(context)
        {

        }
    }
}
