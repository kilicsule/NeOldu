using System;
using System.Collections.Generic;

namespace Neoldu.Data.Domain.Entities
{
    public class ApplicaitonBlock : BaseGuidEntity
    {
        public ApplicaitonBlock()
        {
            ApplicationBlock_ApplicationUsers = new HashSet<ApplicationBlock_ApplicationUser>();
        }
        public Guid PeopleId { get; set; }
        public int BlockCount { get; set; }
        public bool IsBlock { get; set; }
        public People People { get; set; }
        public ICollection<ApplicationBlock_ApplicationUser> ApplicationBlock_ApplicationUsers { get; set; }
    }
}
