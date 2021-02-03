using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using NeOldu.Client.Models.GirisViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace NeOldu.Client.Controllers
{
    public class OturumController : BaseController
    {
        public IActionResult GirisYap()
        {
            var userId = User.Claims.FirstOrDefault(c => c.Type == "Id");
            if (userId != null)
            {
                var user = UnitOfWork.ApplicationUserDal.GetById(Guid.Parse(userId.Value));
                if (user != null)
                {
                    return RedirectToAction("OturumAc", "Oturum", new { Email = user.Email, Password = user.Password });
                }
            }
            return View();
        }
        [HttpGet]
        [Route("OturumAc")]
        public async Task<IActionResult> OturumAc(GirisViewModel girisViewModel)
        {
            if (!ModelState.IsValid) return View("GirisYap");
            var kullanici = UnitOfWork.ApplicationUserDal.GetQueryable().FirstOrDefault(p => p.Email == girisViewModel.Email && p.Password == girisViewModel.Password);
            if (kullanici != null)
            {
                kullanici.ApplicationType = UnitOfWork.ApplicationTypeDal.GetById(kullanici.ApplicationTypeId);
                var userClaims = new List<Claim>()
                {
                    new Claim("Id", kullanici.Id.ToString()),
                    new Claim("Name", kullanici.FirstName),
                    new Claim("Surname", kullanici.LastName),
                    new Claim("Email", kullanici.Email),
                    new Claim("KullaniciTip", kullanici.ApplicationType.Type.ToString()),
                    new Claim(ClaimTypes.Role, kullanici.ApplicationType.Type.ToString()),
                };

                var grandmaIdentity = new ClaimsIdentity(userClaims, "Login");
                var userPrincipal = new ClaimsPrincipal(new[] { grandmaIdentity });
                await HttpContext.SignInAsync(userPrincipal);
                if (kullanici.ApplicationType.Type == "Admin")
                {
                    return RedirectToAction("Index","People");
                }
                else
                    return RedirectToAction("Index", "Anasayfa");
            }
            else
                return View("GirisYap");
        }
        [HttpGet]
        [Route("Cikis")]
        public async Task<IActionResult> Cikis()
        {
            await HttpContext.SignOutAsync();
            return RedirectToAction("GirisYap","Oturum");
        }
    }
}
