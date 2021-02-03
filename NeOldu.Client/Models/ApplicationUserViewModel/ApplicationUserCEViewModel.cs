using Microsoft.AspNetCore.Http;
using Neoldu.Data.Domain.Entities;
using System;

namespace NeOldu.Client.Models.ApplicationUserViewModel
{
    public class ApplicationUserCEViewModel : BaseViewModel
    {
        public Guid ApplicationTypeId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string Image { get; set; }
        public IFormFile ImageFile { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public ApplicationType ApplicationType { get; set; }

    }
}
