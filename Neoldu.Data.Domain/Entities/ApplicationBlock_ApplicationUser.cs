using System;

namespace Neoldu.Data.Domain.Entities
{
    public class ApplicationBlock_ApplicationUser : BaseGuidEntity
    {
        public Guid ApplicaitonBlockId { get; set; }
        public Guid ApplicationUserId { get; set; }
        public ApplicaitonBlock ApplicaitonBlock { get; set; }
        public ApplicationUser ApplicationUser{ get; set; }
    }
}
