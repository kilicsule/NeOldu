using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using NeOldu.Client.Models.ApplicaitonReactionViewModel;
using System;
using System.Linq;
using X.PagedList;

namespace NeOldu.Client.Controllers
{
    [Route("ApplicaitonReaction")]
    [Authorize(Roles = "Admin")]
    public class ApplicaitonReactionController : BaseController
    {
        [Route("Index")]
        public IActionResult Index(int? page)
        {
            var pagenumber = page ?? 1;
            int pagesize = 3;
            var reactionList = UnitOfWork.ApplicaitonReactionDal.GetQueryable().ToList();
            foreach (var item in reactionList)
            {
                item.People = UnitOfWork.PeopleDal.GetById(item.PeopleId);
                item.People.DeathDate = UnitOfWork.DeathDateDal.GetById(item.People.DeathDateId);
            }
            var model = new ApplicaitonReactionHomeViewModel()
            {
                PagedList = reactionList.ToPagedList(pagenumber, pagesize)
            };
            return View(model);
        }
        [Route("Details")]
        public IActionResult Details(Guid id)
        {
            var entity = UnitOfWork.ApplicaitonReactionDal.GetQueryable().FirstOrDefault(p => p.Id == id);
            entity.ApplicaitonReaction_ApplicationUsers = UnitOfWork.ApplicaitonReactionDal.GetApplicationReactionList(id);
            entity.People = UnitOfWork.PeopleDal.GetById(entity.PeopleId);
            return View(entity);
        }

        [Route("ApplicaitonReactionDelete")]
        public IActionResult ApplicaitonReactionDelete(Guid id)
        {
            var entity = UnitOfWork.ApplicaitonReactionDal.GetById(id);
            entity.ApplicaitonReaction_ApplicationUsers = UnitOfWork.ApplicaitonReactionDal.GetApplicationReactionList(id);
            entity.People = UnitOfWork.PeopleDal.GetById(entity.PeopleId);
            return View(entity);
        }

        [HttpPost]
        [Route("Delete")]
        public IActionResult DeleteConfirmed(Guid id)
        {
            var entity = UnitOfWork.ApplicaitonReactionDal.GetById(id);
            UnitOfWork.ApplicaitonReactionDal.Delete(entity);
            UnitOfWork.Commit();
            return RedirectToAction("Index", "ApplicaitonReaction");
        }
    }
}
