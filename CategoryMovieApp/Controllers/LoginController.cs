using CategoryMovieApp.Models;
using CategoryMovieApp.Repositories;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace CategoryMovieApp.Controllers
{
    public class LoginController : Controller
    {
        UserRepository ur = new UserRepository();
        [AllowAnonymous]
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }
        [AllowAnonymous]
        [HttpPost]
        public async Task<IActionResult> Login(User a)
        {
            Context c = new Context();
            var value = c.Users.FirstOrDefault(x=>x.UserName == a.UserName && x.UserPassword == a.UserPassword && x.UserStatu);
            if(value != null) 
            {
                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name,a.UserName),
                    new Claim(ClaimTypes.NameIdentifier, value.UserId.ToString())
                };
                var useridentity = new ClaimsIdentity(claims,"a");
                ClaimsPrincipal pr = new ClaimsPrincipal(useridentity);
                await HttpContext.SignInAsync(pr);
                return RedirectToAction("MovieList", "Movie");
            }
            return View();
        }
        [AllowAnonymous]
        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync();
            return RedirectToAction("MovieListNoComment", "Movie");
        }
        [AllowAnonymous]
        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }
        [AllowAnonymous]
        [HttpPost]
        public IActionResult Register(User u)
        {
           u.UserStatu = true;
           ur.Add(u);
           return RedirectToAction("Login","Login");
        }
    }
}
