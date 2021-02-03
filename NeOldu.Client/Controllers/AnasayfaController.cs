using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Neoldu.Data.Domain.Entities;
using NeOldu.Client.Models.ApplicationUserViewModel;
using NeOldu.Client.Models.HomePageViewModel;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace NeOldu.Client.Controllers
{
    [Route("Anasayfa")]
    [Authorize(Roles = "User")]
    public class AnasayfaController : BaseController
    {
        [Route("Index")]
        public IActionResult Index(int year = 2020)
        {
            HomePageViewModel model = new HomePageViewModel()
            {
                DeathDateList = UnitOfWork.DeathDateDal.GetQueryable().OrderByDescending(p => p.Year).ToList(),
                PeopleList = UnitOfWork.PeopleDal.GetQueryable().Where(p => p.DeathDate.Year == year).OrderBy(p => p.ApplicaitonReaction.ReactionCount).ToList()
            };
            return View(model);
        }
        [HttpGet]
        [Route("SinglePage")]
        public IActionResult SinglePage(Guid Id)
        {
            var commentList = UnitOfWork.ApplicationUserCommentDal.GetQueryable().Where(p => p.PeopleId == Id && p.İsActive == true).ToList();
            foreach (var item in commentList)
            {
                item.People = UnitOfWork.PeopleDal.GetById(item.PeopleId);
                item.ApplicationUser = UnitOfWork.ApplicationUserDal.GetById(item.ApplicationUserId);
            }
            HomePageViewModel model = new HomePageViewModel()
            {
                DeathDateList = UnitOfWork.DeathDateDal.GetQueryable().OrderByDescending(p => p.Year).ToList(),
                PeopleList = UnitOfWork.PeopleDal.GetQueryable().Where(p => p.Id == Id).ToList(),
                PeopleNewsId = Id,
                PeopleCommentList = commentList
            };
            return View(model);
        }

        [HttpGet]
        [Route("KullaniciGuncelle")]
        public IActionResult KullaniciGuncelle()
        {
            var userId = User.Claims.FirstOrDefault(c => c.Type == "Id").Value;
            var model = UnitOfWork.ApplicationUserDal.GetById(Guid.Parse(userId));
            var applicationUser = new ApplicationUserCEViewModel()
            {
                Id = model.Id,
                FirstName = model.FirstName,
                LastName = model.LastName,
                Email = model.Email,
                ApplicationTypeId = model.ApplicationTypeId,
                ApplicationType = model.ApplicationType,
                Password = model.Password,
                UserName = model.UserName,
            };
            return View(applicationUser);
        }
        [HttpPost]
        [Route("KullaniciGuncelleConfirmed")]
        public async Task<IActionResult> KullaniciGuncelleConfirmed(ApplicationUserCEViewModel model)
        {
            if (ModelState.IsValid)
            {
                var userId = User.Claims.FirstOrDefault(c => c.Type == "Id").Value;
                var entity = UnitOfWork.ApplicationUserDal.GetById(Guid.Parse(userId));
                entity.FirstName = model.FirstName;
                entity.LastName = model.LastName;
                entity.Email = model.Email;
                entity.Password = model.Password;
                entity.UserName = model.UserName;
                UnitOfWork.FileManager.ImageDelete(model.Image);
                entity.Image = await UnitOfWork.FileManager.FileImageSaveAsync(model.ImageFile);
                UnitOfWork.Commit();
                return RedirectToAction("Index", "Anasayfa");
            }
            return View();
        }
        [HttpGet]
        [Route("KullaniciYorumEkle")]
        public IActionResult KullaniciYorumEkle(Guid PeopleNewsId, string ApplicationComment)
        {
            var userId = User.Claims.FirstOrDefault(c => c.Type == "Id").Value;
            var model = UnitOfWork.ApplicationUserDal.GetById(Guid.Parse(userId));
            if (UnitOfWork.ApplicationUserCommentDal.GetQueryable().FirstOrDefault(p => p.PeopleId == PeopleNewsId && p.ApplicationUserId == model.Id) == null)
            {
                var applicationUserComment = new ApplicationUserComment()
                {
                    Id = model.Id,
                    Comment = ApplicationComment,
                    PeopleId = PeopleNewsId,
                    İsActive = false,
                    ApplicationUser = model,
                    ApplicationUserId = model.Id
                };
                UnitOfWork.ApplicationUserCommentDal.Add(applicationUserComment);
                UnitOfWork.Commit();
            }
            return RedirectToAction("SinglePage", "Anasayfa", new { Id = PeopleNewsId });
        }

        [HttpGet]
        [Route("HaberTepkiVer")]
        public IActionResult HaberTepkiVer(Guid PeopleNewsId)
        {
            var userId = User.Claims.FirstOrDefault(c => c.Type == "Id").Value;
            var model = UnitOfWork.ApplicationUserDal.GetById(Guid.Parse(userId));
            var peopleReaction = UnitOfWork.ApplicaitonReactionDal.GetQueryable().FirstOrDefault(p => p.PeopleId == PeopleNewsId);

            var people = UnitOfWork.PeopleDal.GetById(PeopleNewsId);
            if (peopleReaction == null)
            {
                var applicationReaction = new ApplicaitonReaction()
                {
                    Id = Guid.NewGuid(),
                    PeopleId = PeopleNewsId
                };
                var applicationReaction_ApplicationUser = new ApplicaitonReaction_ApplicationUser()
                {
                    ApplicationUser = model,
                    ApplicationUserId = model.Id,
                    ApplicaitonReaction = applicationReaction,
                    ApplicaitonReactionId = applicationReaction.Id,
                    Id = Guid.NewGuid()
                };
                applicationReaction.ReactionCount += 1;
                people.ApplicaitonReactionId = applicationReaction.Id;
                applicationReaction.ApplicaitonReaction_ApplicationUsers.Add(applicationReaction_ApplicationUser);
                UnitOfWork.ApplicaitonReactionDal.GetReactionAdd(applicationReaction_ApplicationUser);
                UnitOfWork.ApplicaitonReactionDal.Add(applicationReaction);
                UnitOfWork.Commit();
            }
            else
            {
                if (UnitOfWork.ApplicaitonReactionDal.GetReaction(model.Id, peopleReaction.Id) == null)
                {
                    var applicationReaction_ApplicationUser = new ApplicaitonReaction_ApplicationUser()
                    {
                        ApplicationUser = model,
                        ApplicationUserId = model.Id,
                        ApplicaitonReaction = peopleReaction,
                        ApplicaitonReactionId = peopleReaction.Id,
                        Id = Guid.NewGuid()
                    };
                    UnitOfWork.ApplicaitonReactionDal.GetReactionAdd(applicationReaction_ApplicationUser);
                    peopleReaction.ApplicaitonReaction_ApplicationUsers.Add(applicationReaction_ApplicationUser);
                }
                UnitOfWork.Commit();
            }
            return RedirectToAction("SinglePage", "Anasayfa", new { Id = PeopleNewsId });
        }

        [HttpGet]
        [Route("Bloklama")]
        public IActionResult Bloklama(Guid PeopleNewsId)
        {
            var userId = User.Claims.FirstOrDefault(c => c.Type == "Id").Value;
            var model = UnitOfWork.ApplicationUserDal.GetById(Guid.Parse(userId));
            var peopleBlock = UnitOfWork.ApplicaitonBlockDal.GetQueryable().FirstOrDefault(p => p.PeopleId == PeopleNewsId);

            var people = UnitOfWork.PeopleDal.GetById(PeopleNewsId);
            if (peopleBlock == null)
            {
                var applicationReaction = new ApplicaitonBlock()
                {
                    Id = Guid.NewGuid(),
                    PeopleId = PeopleNewsId
                };
                var applicationBlock_ApplicationUser = new ApplicationBlock_ApplicationUser()
                {
                    ApplicationUser = model,
                    ApplicationUserId = model.Id,
                    ApplicaitonBlock = applicationReaction,
                    ApplicaitonBlockId = applicationReaction.Id,
                    Id = Guid.NewGuid()
                };
                applicationReaction.BlockCount += 1;
                people.ApplicaitonBlockId = applicationReaction.Id;
                applicationReaction.ApplicationBlock_ApplicationUsers.Add(applicationBlock_ApplicationUser);
                UnitOfWork.ApplicaitonBlockDal.GetBlockAdd(applicationBlock_ApplicationUser);
                UnitOfWork.ApplicaitonBlockDal.Add(applicationReaction);
                UnitOfWork.Commit();
            }
            else
            {
                if (UnitOfWork.ApplicaitonBlockDal.GetBlock(model.Id, peopleBlock.Id) == null)
                {
                    var applicationBlock_ApplicationUser = new ApplicationBlock_ApplicationUser()
                    {
                        ApplicationUser = model,
                        ApplicationUserId = model.Id,
                        ApplicaitonBlock = peopleBlock,
                        ApplicaitonBlockId = peopleBlock.Id,
                        Id = Guid.NewGuid()
                    };
                    UnitOfWork.ApplicaitonBlockDal.GetBlockAdd(applicationBlock_ApplicationUser);
                    peopleBlock.ApplicationBlock_ApplicationUsers.Add(applicationBlock_ApplicationUser);
                }
                UnitOfWork.Commit();
            }
            return RedirectToAction("SinglePage", "Anasayfa", new { Id = PeopleNewsId });
        }
    }
}
