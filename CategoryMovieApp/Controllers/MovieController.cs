using CategoryMovieApp.Models;
using CategoryMovieApp.Repositories;
using Microsoft.AspNetCore.Mvc;
using X.PagedList;

namespace CategoryMovieApp.Controllers
{
    public class MovieController : Controller
    {
        MovieRepository mr = new MovieRepository();

        /// Bu Alan Kullanıcı Tarafı
        public IActionResult MovieList(int page=1)
        {
            return View(mr.List().Where(x => x.MovieAddDate <= DateTime.Now).ToPagedList(page,12));
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
            return View(mr.List().OrderByDescending(x=>x.Comments.Count()).ToPagedList(page, 5));
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
            ViewBag.Id = id;
            return View(mr.List().Where(x => x.MovieId == id));
        }

        /// Bu Alan Admin Tarafı

        public IActionResult MovieAdminList()
        {
            return View(mr.List());
        }
        [HttpGet]
        public IActionResult MovieAdd()
        {
            return View();
        }
        [HttpPost]
        public IActionResult MovieAdd(Movie m)
        {
            mr.Add(m);
            return RedirectToAction("MovieAdminList");
        }
        public IActionResult MovieUpdate(Movie m)
        {
            mr.Update(m);
            return View();
        }
        public IActionResult MovieDelete(int id)
        {
            mr.Delete(new Movie { MovieId = id });
            return RedirectToAction("MovieAdminList");
        }
        public IActionResult GetMovie(int id)
        {
            var movie = mr.Get(id);
            return View(movie);
        }
    }   
}
