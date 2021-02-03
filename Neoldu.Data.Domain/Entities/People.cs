using System;
using System.Collections.Generic;

namespace Neoldu.Data.Domain.Entities
{
    public class People : BaseGuidEntity
    {
        public People()
        {
            ApplicationUserComments = new HashSet<ApplicationUserComment>();
        }
        public Guid DeathDateId { get; set; }
        public Guid? ApplicaitonBlockId { get; set; }
        public Guid? ApplicaitonReactionId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Image { get; set; }
        public string Description { get; set; }
        public string Detail { get; set; }
        public string News { get; set; }
        public string Title { get; set; }
        public string SourceLink { get; set; }
        public string IsProtection { get; set; }
        public string ByWhom { get; set; }
        public string WhyKilled { get; set; }
        public string PlaceDeath { get; set; }
        public string WayKilled { get; set; }
        public string Subject { get; set; }
        public virtual DeathDate DeathDate { get; set; }
        public virtual ApplicaitonBlock ApplicaitonBlock{ get; set; }
        public virtual ApplicaitonReaction ApplicaitonReaction{ get; set; }
        public virtual ICollection<ApplicationUserComment> ApplicationUserComments{ get; set; }
    }
}
