using CategoryMovieApp.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace CategoryMovieApp.ViewComponents
{
    public class ListCommentUser : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            MovieRepository mr = new MovieRepository();
            var movielist = mr.List().Where(x => x.MovieStatu == true).OrderBy(x => x.MovieNameTR); ;
            return View(movielist);
        }
    }
}
