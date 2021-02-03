using Neoldu.Data.Domain.Entities;
using NeOldu.Data.Dal.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;

namespace NeOldu.Data.Dal.Concrete
{
    public interface IApplicaitonReactionDal : IEfDal<ApplicaitonReaction>
    {
        List<ApplicaitonReaction_ApplicationUser> GetApplicationReactionList(Guid id);
        ApplicaitonReaction_ApplicationUser GetReaction(Guid id);
        ApplicaitonReaction_ApplicationUser GetReaction(Guid applicationUser, Guid applicationReaction);
        void GetReactionAdd(ApplicaitonReaction_ApplicationUser applicaitonReaction);
    }
    public class ApplicaitonReactionDal : EfDal<ApplicaitonReaction>, IApplicaitonReactionDal
    {
        public ApplicaitonReactionDal(NeOlduDbContext context) : base(context)
        {

        }

        public List<ApplicaitonReaction_ApplicationUser> GetApplicationReactionList(Guid id)
        {
            var reactionList = Context.ApplicaitonReaction_ApplicationUsers.Where(p => p.ApplicaitonReactionId == id).ToList();
            foreach (var item in reactionList)
            {
                item.ApplicationUser = Context.ApplicationUsers.Find(item.ApplicationUserId);
                item.ApplicaitonReaction = Context.ApplicaitonReactions.Find(item.ApplicaitonReactionId);
            }
            return reactionList;
        }

        public ApplicaitonReaction_ApplicationUser GetReaction(Guid id)
        {
            return Context.ApplicaitonReaction_ApplicationUsers.Find(id);
        }

        public ApplicaitonReaction_ApplicationUser GetReaction(Guid applicationUser, Guid applicationReaction)
        {
            return Context.ApplicaitonReaction_ApplicationUsers.FirstOrDefault(p=>p.ApplicationUserId == applicationUser && p.ApplicaitonReactionId == applicationReaction);
        }

        public void GetReactionAdd(ApplicaitonReaction_ApplicationUser applicaitonReaction)
        {
            Context.ApplicaitonReaction_ApplicationUsers.Add(applicaitonReaction);
        }
    }
}
