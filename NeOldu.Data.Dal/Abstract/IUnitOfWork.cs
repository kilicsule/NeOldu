using NeOldu.Data.Dal.Concrete;
using NeOldu.Data.Dal.Core;

namespace NeOldu.Data.Dal.Abstract
{
    public interface IUnitOfWork
    {
        IApplicaitonBlockDal ApplicaitonBlockDal { get; set; }
        IApplicaitonReactionDal ApplicaitonReactionDal { get; set; }
        IApplicationTypeDal ApplicationTypeDal { get; set; }
        IApplicationUserCommentDal ApplicationUserCommentDal { get; set; }
        IApplicationUserDal ApplicationUserDal { get; set; }
        IPeopleDal PeopleDal { get; set; }
        IDeathDateDal DeathDateDal { get; set; }
        IFileManager FileManager { get; set; }
        IMapperService MapperService { get; set; }
        void Commit();
    }
}
