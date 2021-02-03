using Neoldu.Data.Domain.Entities;
using NeOldu.Data.Dal.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;

namespace NeOldu.Data.Dal.Concrete
{
    public interface IApplicaitonBlockDal : IEfDal<ApplicaitonBlock>
    {
        List<ApplicationBlock_ApplicationUser> GetApplicationBlockList(Guid id);
        ApplicationBlock_ApplicationUser GetBlock(Guid id);
        ApplicationBlock_ApplicationUser GetBlock(Guid applicationUserId, Guid applicationBlockId);
        void GetBlockAdd(ApplicationBlock_ApplicationUser applicaitonBlock);
    }
    public class ApplicaitonBlockDal : EfDal<ApplicaitonBlock>, IApplicaitonBlockDal
    {
        private IMapperService _mapperService;
        public ApplicaitonBlockDal(NeOlduDbContext context, IMapperService mapperService) : base(context)
        {
            _mapperService = mapperService;
        }

        public List<ApplicationBlock_ApplicationUser> GetApplicationBlockList(Guid id)
        {
            var blockList = Context.ApplicationBlock_ApplicationUsers.Where(p => p.ApplicaitonBlockId == id).ToList();
            foreach (var item in blockList)
            {
                item.ApplicationUser = Context.ApplicationUsers.Find(item.ApplicationUserId);
                item.ApplicaitonBlock = Context.ApplicaitonBlocks.Find(item.ApplicaitonBlockId);
            }
            return blockList;
        }

        public ApplicationBlock_ApplicationUser GetBlock(Guid id)
        {
            return Context.ApplicationBlock_ApplicationUsers.Find(id);
        }

        public ApplicationBlock_ApplicationUser GetBlock(Guid applicationUserId, Guid applicationBlockId)
        {
            return Context.ApplicationBlock_ApplicationUsers.FirstOrDefault(p=>p.ApplicationUserId == applicationUserId && p.ApplicaitonBlockId == applicationBlockId);
        }

        public void GetBlockAdd(ApplicationBlock_ApplicationUser applicaitonBlock)
        {
            Context.ApplicationBlock_ApplicationUsers.Add(applicaitonBlock);
        }
    }
}
