using CategoryMovieApp.Models;
using CategoryMovieApp.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using X.PagedList;

namespace CategoryMovieApp.Controllers
{
    [Authorize]
    public class UserController : Controller
    {
        UserRepository ur = new UserRepository();
        public IActionResult UserList(int page = 1)
        {
            return View(ur.List().OrderBy(x=>x.UserId).ToPagedList(page, 10));
        }
        public IActionResult UserDelete(int id)
        {
            ur.Delete(new User { UserId = id });
            return RedirectToAction("UserList");
        }
        public IActionResult UserUpdate(User c)
        {
            var user = ur.Get(c.UserId);
            user.UserName = c.UserName;
            user.UserPassword = c.UserPassword;
            user.UserStatu = c.UserStatu;
            user.UserId = c.UserId;
            ur.Update(user);
            return RedirectToAction("UserList");
        }
        public IActionResult GetUser(int id)
        {
            var user = ur.Get(id);
            User c = new User()
            {
                UserId = user.UserId,
                UserName = user.UserName,
                UserPassword = user.UserPassword,
                UserStatu = user.UserStatu
            };
            return View(c);
        }
    }
}

