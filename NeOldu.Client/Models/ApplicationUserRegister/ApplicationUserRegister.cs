using Neoldu.Data.Domain.Entities;
using System;

namespace NeOldu.Client.Models.ApplicationUserRegister
{
    public class ApplicationUserRegister : BaseViewModel
    {
        public Guid ApplicationTypeId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public ApplicationType ApplicationType { get; set; }
    }
}
