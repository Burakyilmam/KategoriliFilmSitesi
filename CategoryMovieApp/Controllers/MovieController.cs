using CategoryMovieApp.Repositories;
using Microsoft.AspNetCore.Mvc;
using X.PagedList;

namespace CategoryMovieApp.Controllers
{
    public class MovieController : Controller
    {
        MovieRepository mr = new MovieRepository();
        public IActionResult MovieList(int page=1)
        {
            return View(mr.List().Where(x => x.MovieAddDate <= DateTime.Now).ToPagedList(page,10));
        }
        public IActionResult NewAdded(int page = 1)
        {
            return View(mr.List().OrderByDescending(x=>x.MovieAddDate).Where(x=>x.MovieAddDate <= DateTime.Now).ToPagedList(page, 10));
        }
        public IActionResult IMDB7(int page = 1)
        {
            return View(mr.List().OrderByDescending(x => x.MovieAddDate).Where(x => x.MovieIMDB >= 7).ToPagedList(page, 10));
        }
        public IActionResult MostComment(int page = 1)
        {
            return View(mr.List().OrderByDescending(x => x.Comments.Count).ToPagedList(page, 10));
        }
        public ActionResult GetCategoryMovie(int id, int page = 1)
        {
            return View(mr.List().OrderByDescending(x => x.MovieAddDate).Where(x => x.CategoryId == id).ToPagedList(page,10));
        }
        public ActionResult GetCountryMovie(int id, int page = 1)
        {
            return View(mr.List().OrderByDescending(x => x.MovieAddDate).Where(x => x.CountryId == id).ToPagedList(page, 10));
        }
        public ActionResult GetYearMovie(int id, int page = 1)
        {
            return View(mr.List().OrderByDescending(x => x.MovieAddDate).Where(x => x.YearId == id).ToPagedList(page, 10));
        }
        public ActionResult MoviePage(int id)
        {
            return View(mr.List().Where(x => x.MovieId == id));
        }
    }
}
