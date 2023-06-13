using CategoryMovieApp.Models;
using CategoryMovieApp.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using X.PagedList;

namespace CategoryMovieApp.Controllers
{
    public class CommentController : Controller
    {
        CommentRepository cr = new CommentRepository();
        public IActionResult CommentList(int page = 1)
        {
            return View(cr.List("Movie","User").Where(x => x.CommentDate <= DateTime.Now).OrderBy(x=>x.MovieId).ToPagedList(page, 12));
        }

    }
}