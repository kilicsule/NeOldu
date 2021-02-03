using System;
using System.Collections.Generic;

namespace Neoldu.Data.Domain.Entities
{
    public class ApplicationType : BaseGuidEntity
    {
        public ApplicationType()
        {
            ApplicationUser = new HashSet<ApplicationUser>();
        }
        public string Type { get; set; }
        public virtual ICollection<ApplicationUser> ApplicationUser { get; set; }
    }
}
