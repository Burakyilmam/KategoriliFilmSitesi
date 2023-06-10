using CategoryMovieApp.Models;
using CategoryMovieApp.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace CategoryMovieApp.ViewComponents
{
    public class ListComment : ViewComponent
    {
        public IViewComponentResult Invoke(int id)
        {
            CommentRepository cr = new CommentRepository();
            var commentlist = cr.List("User").Where(x=>x.MovieId == id);
            return View(commentlist);
        }
    }
}
