using CategoryMovieApp.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace CategoryMovieApp.ViewComponents
{
    public class ListSliderEN : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            MovieRepository mr = new MovieRepository();
            var movielist = mr.List().Where(x => x.MovieStatu == true).OrderBy(x => x.MovieAddDate);
            return View(movielist);
        }
    }
}
