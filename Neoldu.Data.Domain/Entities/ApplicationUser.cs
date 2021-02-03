using System;
using System.Collections.Generic;

namespace Neoldu.Data.Domain.Entities
{
    public class ApplicationUser : BaseGuidEntity
    {
        public ApplicationUser()
        {
            ApplicationUserComments = new HashSet<ApplicationUserComment>();
            ApplicationBlock_ApplicationUsers = new HashSet<ApplicationBlock_ApplicationUser>();
            ApplicaitonReaction_ApplicationUsers = new HashSet<ApplicaitonReaction_ApplicationUser>();
        }
        public Guid ApplicationTypeId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string Image { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public ApplicationType ApplicationType { get; set; }
        public virtual ICollection<ApplicationUserComment> ApplicationUserComments{ get; set; }
        public ICollection<ApplicationBlock_ApplicationUser> ApplicationBlock_ApplicationUsers { get; set; }
        public ICollection<ApplicaitonReaction_ApplicationUser> ApplicaitonReaction_ApplicationUsers { get; set; }
    }
}
