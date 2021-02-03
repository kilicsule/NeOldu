using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Neoldu.Data.Domain.Entities;
using NeOldu.Client.Models;
using NeOldu.Client.Models.ApplicationUserRegister;
using System;
using System.Diagnostics;
using System.Linq;

namespace NeOldu.Client.Controllers
{
    public class HomeController : BaseController
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        [Route("Uyelik")]
        public IActionResult Uyelik()
        {
            return View();
        }

        [HttpPost]
        [Route("Uyelik")]
        public IActionResult Uyelik(ApplicationUserRegister model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            else
            {
                if (UnitOfWork.ApplicationUserDal.GetQueryable().FirstOrDefault(p => p.Email == model.Email) == null)
                {

                    var applicationType = UnitOfWork.ApplicationTypeDal.GetQueryable().FirstOrDefault(p => p.Type == "User");
                    var applicationUser = new ApplicationUser()
                    {
                        ApplicationType = applicationType,
                        ApplicationTypeId = applicationType.Id,
                        Id = Guid.NewGuid(),
                        Email = model.Email,
                        FirstName = model.FirstName,
                        LastName = model.LastName,
                        Password = model.Password,
                        UserName = model.UserName,
                        Image = "avatar.png"
                    };
                    applicationType.ApplicationUser.Add(applicationUser);
                    UnitOfWork.ApplicationUserDal.Add(applicationUser);
                    UnitOfWork.Commit();
                    return RedirectToAction("OturumAc", "Oturum", new { Email = model.Email, Password = applicationUser.Password });
                }
                else
                    return View(model);
            }
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
