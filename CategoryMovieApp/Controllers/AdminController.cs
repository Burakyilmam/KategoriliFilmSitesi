using CategoryMovieApp.Models;
using CategoryMovieApp.Repositories;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using X.PagedList;

namespace CategoryMovieApp.Controllers
{
    public class AdminController : Controller
    {
        AdminRepository ar = new AdminRepository();
        [AllowAnonymous]
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }
        [AllowAnonymous]
        [HttpPost]
        public async Task<IActionResult> Login(Admin a)
        {
            Context c = new Context();
            var value = c.Admins.FirstOrDefault(x => x.AdminName == a.AdminName && x.AdminPassword == a.AdminPassword && x.AdminStatu);
            if (value != null)
            {
                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name,a.AdminName),
                    new Claim(ClaimTypes.NameIdentifier, value.AdminId.ToString())
                };
                var adminidentity = new ClaimsIdentity(claims, "a");
                ClaimsPrincipal pr = new ClaimsPrincipal(adminidentity);
                await HttpContext.SignInAsync(pr);
                return RedirectToAction("AdminPage", "Admin");
            }
            return View();
        }
        [AllowAnonymous]
        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync();
            return RedirectToAction("MovieListNoComment", "Movie");
        }
        public IActionResult AdminPage()
        {
            var adminIdClaim = HttpContext.User.Claims.FirstOrDefault(c => c.Type == ClaimTypes.NameIdentifier)?.Value;
            if (!string.IsNullOrEmpty(adminIdClaim))
            {
                int userId = int.Parse(adminIdClaim);
                Context c = new Context();
                var user = c.Admins.FirstOrDefault(x => x.AdminId == userId && x.AdminStatu);
                if (user != null)
                {
                    var username = User.Identity.Name;
                    ViewBag.Name = username;
                    ViewBag.Id = userId;
                    return View();
                }
            }
            return RedirectToAction("Login", "Admin");
        }
        [AllowAnonymous]
        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }
        [AllowAnonymous]
        [HttpPost]
        public IActionResult Register(Admin u)
        {
            u.AdminStatu = true;
            ar.Add(u);
            return RedirectToAction("Login", "Admin");
        }
        public IActionResult AdminList(int page = 1)
        {
            return View(ar.List().OrderBy(x => x.AdminId).ToPagedList(page, 10));
        }
        public IActionResult AdminDelete(int id)
        {
            ar.Delete(new Admin {AdminId = id });
            return RedirectToAction("AdminList");
        }
        public IActionResult AdminUpdate(Admin c)
        {
            var admin = ar.Get(c.AdminId);
            admin.AdminName = c.AdminName;
            admin.AdminPassword = c.AdminPassword;
            admin.AdminStatu = c.AdminStatu;
            admin.AdminId = c.AdminId;
            ar.Update(admin);
            return RedirectToAction("AdminList");
        }
        public IActionResult GetAdmin(int id)
        {
            var admin = ar.Get(id);
            Admin c = new Admin()
            {
                AdminId = admin.AdminId,
                AdminName = admin.AdminName,
                AdminPassword = admin.AdminPassword,
                AdminStatu = admin.AdminStatu
            };
            return View(c);
        }
    }
}

