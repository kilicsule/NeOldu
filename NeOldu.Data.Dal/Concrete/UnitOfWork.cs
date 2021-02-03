using NeOldu.Data.Dal.Abstract;
using NeOldu.Data.Dal.Core;

namespace NeOldu.Data.Dal.Concrete
{
    public class UnitOfWork : IUnitOfWork
    {
        public UnitOfWork(NeOlduDbContext context, IApplicaitonBlockDal applicaitonBlockDal,
            IApplicaitonReactionDal applicaitonReactionDal, IApplicationTypeDal applicationTypeDal,
            IApplicationUserCommentDal applicationUserCommentDal, IApplicationUserDal applicationUser,
            IPeopleDal peopleDal, IDeathDateDal deathDateDal, IFileManager fileManager,
            IMapperService mapperService)
        {
            Context = context;
            ApplicationUserDal = applicationUser;
            ApplicaitonBlockDal = applicaitonBlockDal;
            ApplicaitonReactionDal = applicaitonReactionDal;
            ApplicationTypeDal = applicationTypeDal;
            ApplicationUserCommentDal = applicationUserCommentDal;
            PeopleDal = peopleDal;
            DeathDateDal = deathDateDal;
            FileManager = fileManager;
            MapperService = mapperService;
        }
        public NeOlduDbContext Context; 
        public IApplicaitonBlockDal ApplicaitonBlockDal { get; set; }
        public IApplicaitonReactionDal ApplicaitonReactionDal { get; set; }
        public IApplicationTypeDal ApplicationTypeDal { get; set; }
        public IApplicationUserCommentDal ApplicationUserCommentDal { get; set; }
        public IApplicationUserDal ApplicationUserDal { get; set; }
        public IPeopleDal PeopleDal { get; set; }
        public IFileManager FileManager{ get; set; }
        public IDeathDateDal DeathDateDal { get; set; }
        public IMapperService MapperService{ get; set; }
        public void Commit()
        {
            Context.SaveChanges();
        }
    }
}
