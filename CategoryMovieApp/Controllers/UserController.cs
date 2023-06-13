using CategoryMovieApp.Repositories;
using Microsoft.AspNetCore.Mvc;
using X.PagedList;

namespace CategoryMovieApp.Controllers
{
    public class UserController : Controller
    {
        UserRepository ur = new UserRepository();
        public IActionResult UserList(int page = 1)
        {
            return View(ur.List().OrderBy(x=>x.UserId).ToPagedList(page, 10));
        }
    }
}
