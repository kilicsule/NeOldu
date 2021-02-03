using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using NeOldu.Client.Models.ApplicationUserCommentViewModel;
using System;
using System.Linq;
using X.PagedList;

namespace NeOldu.Client.Controllers
{
    [Route("ApplicationUserComment")]
    [Authorize(Roles = "Admin")]
    public class ApplicationUserCommentController : BaseController
    {
        [Route("Index")]
        public IActionResult Index(int? page)
        {
            var pagenumber = page ?? 1;
            int pagesize = 3;
            var commentList = UnitOfWork.ApplicationUserCommentDal.GetQueryable().ToList();
            foreach (var item in commentList)
            {
                item.ApplicationUser = UnitOfWork.ApplicationUserDal.GetById(item.ApplicationUserId);
                item.People = UnitOfWork.PeopleDal.GetById(item.PeopleId);
            }
            var model = new ApplicationUserCommentHomeViewModel()
            {
                PagedList = commentList.ToPagedList(pagenumber, pagesize)
            };

            return View(model);
        }
        [Route("Details")]
        public IActionResult Details(Guid id)
        {
            var entity = UnitOfWork.ApplicationUserCommentDal.GetById(id);
            entity.ApplicationUser = UnitOfWork.ApplicationUserDal.GetById(entity.ApplicationUserId);
            entity.People = UnitOfWork.PeopleDal.GetById(entity.PeopleId);
            return View(entity);
        }

        [Route("ApplicationUserCommentDelete")]
        public IActionResult ApplicationUserCommentDelete(Guid id)
        {
            var entity = UnitOfWork.ApplicationUserCommentDal.GetById(id);
            entity.ApplicationUser = UnitOfWork.ApplicationUserDal.GetById(entity.ApplicationUserId);
            entity.People = UnitOfWork.PeopleDal.GetById(entity.PeopleId);
            return View(entity);
        }

        [HttpPost]
        [Route("Delete")]
        public IActionResult DeleteConfirmed(Guid id)
        {
            var entity = UnitOfWork.ApplicationUserCommentDal.GetById(id);
            UnitOfWork.ApplicationUserCommentDal.Delete(entity);
            UnitOfWork.Commit();
            return RedirectToAction("Index", "ApplicationUserComment");
        }

        [HttpGet]
        [Route("CommentOnayla")]
        public IActionResult CommentOnayla(Guid id)
        {
            var entity = UnitOfWork.ApplicationUserCommentDal.GetById(id);
            entity.İsActive = true;
            UnitOfWork.Commit();
            return RedirectToAction("Index", "ApplicationUserComment");
        }
        [HttpGet]
        [Route("CommentOnaylaGeriAl")]
        public IActionResult CommentOnaylaGeriAl(Guid id)
        {
            var entity = UnitOfWork.ApplicationUserCommentDal.GetById(id);
            entity.İsActive = false;
            UnitOfWork.Commit();
            return RedirectToAction("Index", "ApplicationUserComment");
        }
    }
}
