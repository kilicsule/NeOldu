using System;

namespace Neoldu.Data.Domain.Entities
{
    public class ApplicationUserComment : BaseGuidEntity
    {
        public Guid PeopleId { get; set; }
        public Guid ApplicationUserId { get; set; }
        public string Comment { get; set; }
        public bool İsActive { get; set; } = false;
        public virtual People People { get; set; }
        public virtual ApplicationUser ApplicationUser { get; set; }
    }
}
