using Neoldu.Data.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Neoldu.Data.Domain.EntitiesDTO
{
    public class ApplicationUserBlockDTO
    {
        public ApplicationUserBlockDTO()
        {
            ApplicationUsers = new List<ApplicationUser>();
        }
        public Guid PeopleId { get; set; }
        public int BlockCount { get; set; }
        public bool IsBlock { get; set; }
        public virtual People People { get; set; }
        public List<ApplicationUser> ApplicationUsers { get; set; }
    }
}
