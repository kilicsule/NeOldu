using Neoldu.Data.Domain.Entities;
using System;
using System.Collections.Generic;

namespace NeOldu.Client.Models.HomePageViewModel
{
    public class HomePageViewModel : BaseHomeViewModel<DeathDate>
    {
        public HomePageViewModel()
        {
            PeopleList = new List<People>();
            DeathDateList = new List<DeathDate>();
            PeopleCommentList = new List<ApplicationUserComment>();
        }
        public Guid PeopleNewsId { get; set; }
        public string ApplicationComment { get; set; }
        public List<People> PeopleList { get; set; }
        public List<DeathDate> DeathDateList { get; set; }
        public List<ApplicationUserComment> PeopleCommentList { get; set; }
        public List<ApplicaitonBlock> ApplicationUserBlock { get; set; }
        public List<ApplicaitonReaction> ApplicaitonReactionList { get; set; }

    }
}
