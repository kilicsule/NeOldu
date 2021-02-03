using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Neoldu.Data.Domain.Entities;
using NeOldu.Client.Models.ApplicationUserViewModel;
using System;
using System.Linq;
using System.Threading.Tasks;
using X.PagedList;

namespace NeOldu.Client.Controllers
{
    [Route("ApplicationUser")]
    [Authorize(Roles = "Admin")]
    public class ApplicationUserController : BaseController
    {
        [Route("Index")]
        public IActionResult Index(int? page)
        {
            var pagenumber = page ?? 1;
            int pagesize = 3;
            var model = new ApplicationUserHomeViewModel()
            {
                PagedList = UnitOfWork.ApplicationUserDal.GetQueryable().ToPagedList(pagenumber, pagesize)
            };
            return View(model);
        }
        [Route("Create")]
        public IActionResult Create()
        {
            ViewBag.ApplicationType = UnitOfWork.ApplicationTypeDal.GetQueryable().OrderByDescending(p => p.Type)
                .Select(a => new SelectListItem() { Value = a.Id.ToString(), Text = a.Type }).ToList();
            return View();
        }
        [HttpPost]
        [Route("Create")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateConfirmed(ApplicationUserCEViewModel model)
        {
            if (ModelState.IsValid)
            {
                var ApplicationUser = new ApplicationUser()
                {
                    Id = Guid.NewGuid(),
                    FirstName = model.FirstName,
                    LastName = model.LastName,
                    Email = model.Email,
                    ApplicationTypeId = model.ApplicationTypeId,
                    ApplicationType = model.ApplicationType,
                    Password = model.Password,
                    UserName = model.UserName,
                };
                ApplicationUser.Image = await UnitOfWork.FileManager.FileImageSaveAsync(model.ImageFile);
                UnitOfWork.ApplicationUserDal.Add(ApplicationUser);
                UnitOfWork.Commit();
                return RedirectToAction("Index", "ApplicationUser");
            }
            ViewBag.ApplicationType = UnitOfWork.ApplicationTypeDal.GetQueryable().OrderByDescending(p => p.Type)
                 .Select(a => new SelectListItem() { Value = a.Id.ToString(), Text = a.Type }).ToList();
            return View();
        }
        [Route("Edit")]
        public IActionResult Edit(Guid id)
        {
            var model = UnitOfWork.ApplicationUserDal.GetById(id);
            ViewBag.ApplicationType = UnitOfWork.ApplicationTypeDal.GetQueryable().OrderByDescending(p => p.Type)
                 .Select(a => new SelectListItem() { Value = a.Id.ToString(), Text = a.Type }).ToList();
            var ApplicationUser = new ApplicationUserCEViewModel()
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
            return View(ApplicationUser);
        }

        [HttpPost]
        [Route("Edit")]
        public async Task<IActionResult> EditConfirmed(ApplicationUserCEViewModel model)
        {
            if (ModelState.IsValid)
            {
                var entity = UnitOfWork.ApplicationUserDal.GetById(model.Id);
                entity.FirstName = model.FirstName;
                entity.LastName = model.LastName;
                entity.Email = model.Email;
                entity.ApplicationTypeId = model.ApplicationTypeId;
                entity.ApplicationType = model.ApplicationType;
                entity.Password = model.Password;
                entity.UserName = model.UserName;
                UnitOfWork.FileManager.ImageDelete(model.Image);
                entity.Image = await UnitOfWork.FileManager.FileImageSaveAsync(model.ImageFile);
                UnitOfWork.Commit();
                return RedirectToAction("Index", "ApplicationUser");
            }
            ViewBag.ApplicationType = UnitOfWork.ApplicationTypeDal.GetQueryable().OrderByDescending(p => p.Type)
                 .Select(a => new SelectListItem() { Value = a.Id.ToString(), Text = a.Type }).ToList();
            return View();
        }

        [Route("Details")]
        public IActionResult Details(Guid id)
        {
            var entity = UnitOfWork.ApplicationUserDal.GetById(id);
            return View(entity);
        }

        [Route("ApplicationUserDelete")]
        public IActionResult ApplicationUserDelete(Guid id)
        {
            var entity = UnitOfWork.ApplicationUserDal.GetById(id);
            return View(entity);
        }

        [HttpPost]
        [Route("Delete")]
        public IActionResult DeleteConfirmed(Guid id)
        {
            var entity = UnitOfWork.ApplicationUserDal.GetById(id);
            UnitOfWork.FileManager.ImageDelete(entity.Image);
            UnitOfWork.ApplicationUserDal.Delete(entity);
            UnitOfWork.Commit();
            return RedirectToAction("Index", "ApplicationUser");
        }
    }
}
