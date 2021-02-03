using System;
using System.Collections.Generic;

namespace Neoldu.Data.Domain.Entities
{
    public class ApplicaitonReaction : BaseGuidEntity
    {
        public ApplicaitonReaction()
        {
            ApplicaitonReaction_ApplicationUsers = new HashSet<ApplicaitonReaction_ApplicationUser>();
        }
        public Guid PeopleId { get; set; }
        public int ReactionCount { get; set; }
        public virtual People People{ get; set; }
        public ICollection<ApplicaitonReaction_ApplicationUser> ApplicaitonReaction_ApplicationUsers { get; set; }
    }
}
