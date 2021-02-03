using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Neoldu.Data.Domain.Entities;
using NeOldu.Client.Controllers;
using NeOldu.Client.Models.DeathDateViewModel;
using System;
using System.Linq;
using X.PagedList;

namespace NeOldu.Client.Areas.Client.Controllers
{
    [Route("DeathDate")]
    [Authorize(Roles = "Admin")]
    public class DeathDateController : BaseController
    {
        [Route("Index")]
        public IActionResult Index(int? page)
        {
            var pagenumber = page ?? 1;
            int pagesize = 3;
            var model = new DeathDateHomeViewModel()
            {
                PagedList = UnitOfWork.DeathDateDal.GetQueryable().OrderBy(p=>p.Year).ToPagedList(pagenumber, pagesize)
            };
            return View(model);
        }
        [Route("Create")]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [Route("Create")]
        [ValidateAntiForgeryToken]
        public IActionResult CreateConfirmed(DeathDateCEViewModel model)
        {
            if (ModelState.IsValid)
            {
                if (UnitOfWork.DeathDateDal.GetQueryable().FirstOrDefault(p => p.Year == model.Year) == null)
                {
                    var deathDate = new DeathDate()
                    {
                        Id = Guid.NewGuid(),
                        Year = model.Year
                    };
                    UnitOfWork.DeathDateDal.Add(deathDate);
                    UnitOfWork.Commit();
                    return RedirectToAction("Index", "DeathDate");
                }
            }
            return RedirectToAction("Index", "DeathDate");
        }
        [Route("Edit")]
        public IActionResult Edit(Guid id)
        {
            var model = UnitOfWork.DeathDateDal.GetById(id);
            var DeathDate = new DeathDateCEViewModel()
            {
                Id = model.Id,
                Year = model.Year
            };
            return View(DeathDate);
        }

        [HttpPost]
        [Route("Edit")]
        public IActionResult EditConfirmed(DeathDateCEViewModel model)
        {
            if (ModelState.IsValid)
            {
                var entity = UnitOfWork.DeathDateDal.GetById(model.Id);
                entity.Year = model.Year;
                UnitOfWork.Commit();
                return RedirectToAction("Index", "DeathDate");
            }
            return View();
        }

        [Route("Details")]
        public IActionResult Details(Guid id)
        {
            var entity = UnitOfWork.DeathDateDal.GetById(id);
            entity.Peoples = UnitOfWork.PeopleDal.GetQueryable().Where(p => p.DeathDateId == entity.Id).ToList();
            return View(entity);
        }
        [HttpGet]
        [Route("Delete")]
        public IActionResult DeathDateDelete(Guid id)
        {
            var entity = UnitOfWork.DeathDateDal.GetById(id);
            var peoples = UnitOfWork.PeopleDal.GetQueryable().Where(p => p.DeathDateId == entity.Id);
            UnitOfWork.PeopleDal.DeleteRange(peoples);
            UnitOfWork.DeathDateDal.Delete(entity);
            UnitOfWork.Commit();
            return RedirectToAction("Index", "DeathDate");
        }
    }
}
