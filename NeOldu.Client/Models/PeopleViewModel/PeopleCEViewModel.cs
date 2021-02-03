using Microsoft.AspNetCore.Http;
using System;

namespace NeOldu.Client.Models.PeopleViewModel
{
    public class PeopleCEViewModel : BaseViewModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public IFormFile Image { get; set; }
        public string ImagePath { get; set; }
        public string Title { get; set; }
        public string News { get; set; }
        public string Detail { get; set; }
        public string Description { get; set; }
        public string SourceLink { get; set; }
        public string IsProtection { get; set; }
        public string ByWhom { get; set; }
        public string WhyKilled { get; set; }
        public string PlaceDeath { get; set; }
        public string WayKilled { get; set; }
        public string Subject { get; set; }
        public Guid DeathDateId { get; set; }
    }
}
