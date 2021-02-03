using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Neoldu.Data.Domain.Entities;
using Neoldu.Data.Domain.EntitiesDTO;
using NeOldu.Client.Models.ApplicaitonBlockViewModel;
using System;
using System.Linq;
using X.PagedList;

namespace NeOldu.Client.Controllers
{
    [Route("ApplicaitonBlock")]
    [Authorize(Roles = "Admin")]
    public class ApplicaitonBlockController : BaseController
    {
        [Route("Index")]
        public IActionResult Index(int? page)
        {
            var pagenumber = page ?? 1;
            int pagesize = 3;
            var blocklist = UnitOfWork.ApplicaitonBlockDal.GetQueryable().ToList();
            foreach (var item in blocklist)
            {
                item.People = UnitOfWork.PeopleDal.GetById(item.PeopleId);
                item.People.DeathDate = UnitOfWork.DeathDateDal.GetById(item.People.DeathDateId);
            }
            var model = new ApplicaitonBlockHomeViewModel()
            {
                PagedList = blocklist.ToPagedList(pagenumber, pagesize)
            };
            return View(model);
        }
        [Route("Details")]
        public IActionResult Details(Guid id)
        {
            var entity = UnitOfWork.ApplicaitonBlockDal.GetQueryable().FirstOrDefault(p=>p.Id == id);
            entity.ApplicationBlock_ApplicationUsers = UnitOfWork.ApplicaitonBlockDal.GetApplicationBlockList(id);
            entity.People = UnitOfWork.PeopleDal.GetById(entity.PeopleId);
            return View(entity);
        }

        [Route("ApplicaitonBlockDelete")]
        public IActionResult ApplicaitonBlockDelete(Guid id)
        {
            var entity = UnitOfWork.ApplicaitonBlockDal.GetById(id);
            entity.ApplicationBlock_ApplicationUsers = UnitOfWork.ApplicaitonBlockDal.GetApplicationBlockList(id);
            entity.People = UnitOfWork.PeopleDal.GetById(entity.PeopleId);
            return View(entity);
        }

        [HttpPost]
        [Route("Delete")]
        public IActionResult DeleteConfirmed(Guid id)
        {
            var entity = UnitOfWork.ApplicaitonBlockDal.GetById(id);
            UnitOfWork.ApplicaitonBlockDal.Delete(entity);
            UnitOfWork.Commit();
            return RedirectToAction("Index", "ApplicaitonBlock");
        }

        [HttpGet]
        [Route("BlockOnayla")]
        public IActionResult BlockOnayla(Guid id)
        {
            var entity = UnitOfWork.ApplicaitonBlockDal.GetById(id);
            entity.IsBlock = true;
            UnitOfWork.Commit();
            return RedirectToAction("Index", "ApplicaitonBlock");
        }
        [HttpGet]
        [Route("BlockOnaylaGeriAl")]
        public IActionResult BlockOnaylaGeriAl(Guid id)
        {
            var entity = UnitOfWork.ApplicaitonBlockDal.GetById(id);
            entity.IsBlock = false;
            UnitOfWork.Commit();
            return RedirectToAction("Index", "ApplicaitonBlock");
        }
    }
}
