using CategoryMovieApp.Repositories;
using Microsoft.AspNetCore.Mvc;
using X.PagedList;

namespace CategoryMovieApp.ViewComponents
{
    public class ListSlider : ViewComponent
    {
        public IViewComponentResult Invoke(int sayfa = 1)
        {
            MovieRepository mr = new MovieRepository();
            var movielist = mr.List().Where(x => x.MovieStatu == true).OrderBy(x => x.MovieAddDate).ToPagedList(sayfa,10);
            return View(movielist);
        }
    }
}
