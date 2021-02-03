using System;

namespace Neoldu.Data.Domain.Entities
{
    public class ApplicaitonReaction_ApplicationUser : BaseGuidEntity
    {
        public Guid ApplicaitonReactionId { get; set; }
        public Guid ApplicationUserId { get; set; }
        public ApplicaitonReaction ApplicaitonReaction{ get; set; }
        public ApplicationUser ApplicationUser{ get; set; }
    }
}
