using CategoryMovieApp.Models;
using CategoryMovieApp.Repositories;
using Microsoft.AspNetCore.Mvc;
using X.PagedList;
using System.Globalization;
using System.Diagnostics.Metrics;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Xml.Linq;

namespace CategoryMovieApp.Controllers
{
    public class MovieController : Controller
    {
        MovieRepository mr = new MovieRepository();

        /// Bu Alan Kullanıcı Tarafı
        public IActionResult MovieList(string p , int page=1)
        {
            if (!string.IsNullOrEmpty(p))
            {
                return View(mr.List("Year").Where(x=>(x.MovieNameTR.Contains((CultureInfo.CurrentCulture.TextInfo.ToTitleCase(p.ToLower()))) || (x.MovieNameEN.Contains(CultureInfo.CurrentCulture.TextInfo.ToTitleCase(p.ToLower()))))).ToPagedList(page,12));
            }
            return View(mr.List("Year").Where(x => x.MovieAddDate <= DateTime.Now).ToPagedList(page,12));
        }
        public IActionResult MovieListEN(string p, int page = 1)
        {
            if (!string.IsNullOrEmpty(p))
            {
                return View(mr.List("Year").Where(x => (x.MovieNameTR.Contains((CultureInfo.CurrentCulture.TextInfo.ToTitleCase(p.ToLower()))) || (x.MovieNameEN.Contains(CultureInfo.CurrentCulture.TextInfo.ToTitleCase(p.ToLower()))))).ToPagedList(page, 12));
            }
            return View(mr.List("Year").Where(x => x.MovieAddDate <= DateTime.Now).ToPagedList(page, 12));
        }
        public IActionResult NewAdded(string p , int page = 1)
        {
            if (!string.IsNullOrEmpty(p))
            {
                return View(mr.List("Year").Where(x => (x.MovieNameTR.Contains((CultureInfo.CurrentCulture.TextInfo.ToTitleCase(p.ToLower()))) || (x.MovieNameEN.Contains(CultureInfo.CurrentCulture.TextInfo.ToTitleCase(p.ToLower()))))).ToPagedList(page, 12));
            }
            return View(mr.List("Year").OrderByDescending(x=>x.MovieAddDate).Where(x=>x.MovieAddDate <= DateTime.Now).ToPagedList(page, 12));
        }
        public IActionResult NewAddedEN(string p, int page = 1)
        {
            if (!string.IsNullOrEmpty(p))
            {
                return View(mr.List("Year").Where(x => (x.MovieNameTR.Contains((CultureInfo.CurrentCulture.TextInfo.ToTitleCase(p.ToLower()))) || (x.MovieNameEN.Contains(CultureInfo.CurrentCulture.TextInfo.ToTitleCase(p.ToLower()))))).ToPagedList(page, 12));
            }
            return View(mr.List("Year").OrderByDescending(x => x.MovieAddDate).Where(x => x.MovieAddDate <= DateTime.Now).ToPagedList(page, 12));
        }
        public IActionResult IMDB7(string p, int page = 1)
        {
            if (!string.IsNullOrEmpty(p))
            {
                return View(mr.List("Year").Where(x => (x.MovieNameTR.Contains((CultureInfo.CurrentCulture.TextInfo.ToTitleCase(p.ToLower()))) || (x.MovieNameEN.Contains(CultureInfo.CurrentCulture.TextInfo.ToTitleCase(p.ToLower()))))).ToPagedList(page, 12));
            }
            return View(mr.List("Year").OrderByDescending(x => x.MovieIMDB).Where(x => x.MovieIMDB >= 7).ToPagedList(page, 12));
        }
        public IActionResult IMDB7EN(string p, int page = 1)
        {
            if (!string.IsNullOrEmpty(p))
            {
                return View(mr.List("Year").Where(x => (x.MovieNameTR.Contains((CultureInfo.CurrentCulture.TextInfo.ToTitleCase(p.ToLower()))) || (x.MovieNameEN.Contains(CultureInfo.CurrentCulture.TextInfo.ToTitleCase(p.ToLower()))))).ToPagedList(page, 12));
            }
            return View(mr.List("Year").OrderByDescending(x => x.MovieIMDB).Where(x => x.MovieIMDB >= 7).ToPagedList(page, 12));
        }
        public IActionResult MostComment(string p, int page = 1)
        {
            if (!string.IsNullOrEmpty(p))
            {
                return View(mr.List("Year").Where(x => (x.MovieNameTR.Contains((CultureInfo.CurrentCulture.TextInfo.ToTitleCase(p.ToLower()))) || (x.MovieNameEN.Contains(CultureInfo.CurrentCulture.TextInfo.ToTitleCase(p.ToLower()))))).ToPagedList(page, 12));
            }
            return View(mr.MostComment("Year").ToPagedList(page, 12));
        }
        public IActionResult MostCommentEN(string p, int page = 1)
        {
            if (!string.IsNullOrEmpty(p))
            {
                return View(mr.List("Year").Where(x => (x.MovieNameTR.Contains((CultureInfo.CurrentCulture.TextInfo.ToTitleCase(p.ToLower()))) || (x.MovieNameEN.Contains(CultureInfo.CurrentCulture.TextInfo.ToTitleCase(p.ToLower()))))).ToPagedList(page, 12));
            }
            return View(mr.MostComment("Year").ToPagedList(page, 12));
        }
        public ActionResult GetCategoryMovie(string p ,int id, int page = 1)
        {
            if (!string.IsNullOrEmpty(p))
            {
                return View(mr.List("Year").Where(x => (x.MovieNameTR.Contains((CultureInfo.CurrentCulture.TextInfo.ToTitleCase(p.ToLower()))) || (x.MovieNameEN.Contains(CultureInfo.CurrentCulture.TextInfo.ToTitleCase(p.ToLower()))))).ToPagedList(page, 12));
            }
            return View(mr.List("Year").OrderByDescending(x => x.MovieAddDate).Where(x => x.CategoryId == id).ToPagedList(page, 12));
        }
        public ActionResult GetCategoryMovieEN(string p, int id, int page = 1)
        {
            if (!string.IsNullOrEmpty(p))
            {
                return View(mr.List("Year").Where(x => (x.MovieNameTR.Contains((CultureInfo.CurrentCulture.TextInfo.ToTitleCase(p.ToLower()))) || (x.MovieNameEN.Contains(CultureInfo.CurrentCulture.TextInfo.ToTitleCase(p.ToLower()))))).ToPagedList(page, 12));
            }
            return View(mr.List("Year").OrderByDescending(x => x.MovieAddDate).Where(x => x.CategoryId == id).ToPagedList(page, 12));
        }
        public ActionResult GetCountryMovie(string p, int id, int page = 1)
        {
            if (!string.IsNullOrEmpty(p))
            {
                return View(mr.List("Year").Where(x => (x.MovieNameTR.Contains((CultureInfo.CurrentCulture.TextInfo.ToTitleCase(p.ToLower()))) || (x.MovieNameEN.Contains(CultureInfo.CurrentCulture.TextInfo.ToTitleCase(p.ToLower()))))).ToPagedList(page, 12));
            }
            return View(mr.List("Year").OrderByDescending(x => x.MovieAddDate).Where(x => x.CountryId == id).ToPagedList(page, 12));
        }
        public ActionResult GetCountryMovieEN(string p, int id, int page = 1)
        {
            if (!string.IsNullOrEmpty(p))
            {
                return View(mr.List("Year").Where(x => (x.MovieNameTR.Contains((CultureInfo.CurrentCulture.TextInfo.ToTitleCase(p.ToLower()))) || (x.MovieNameEN.Contains(CultureInfo.CurrentCulture.TextInfo.ToTitleCase(p.ToLower()))))).ToPagedList(page, 12));
            }
            return View(mr.List("Year").OrderByDescending(x => x.MovieAddDate).Where(x => x.CountryId == id).ToPagedList(page, 12));
        }
        public ActionResult GetYearMovie(string p, int id, int page = 1)
        {
            if (!string.IsNullOrEmpty(p))
            {
                return View(mr.List("Year").Where(x => (x.MovieNameTR.Contains((CultureInfo.CurrentCulture.TextInfo.ToTitleCase(p.ToLower()))) || (x.MovieNameEN.Contains(CultureInfo.CurrentCulture.TextInfo.ToTitleCase(p.ToLower()))))).ToPagedList(page, 12));
            }
            return View(mr.List("Year").OrderByDescending(x => x.MovieAddDate).Where(x => x.YearId == id).ToPagedList(page, 12));
        }
        public ActionResult GetYearMovieEN(string p, int id, int page = 1)
        {
            if (!string.IsNullOrEmpty(p))
            {
                return View(mr.List("Year").Where(x => (x.MovieNameTR.Contains((CultureInfo.CurrentCulture.TextInfo.ToTitleCase(p.ToLower()))) || (x.MovieNameEN.Contains(CultureInfo.CurrentCulture.TextInfo.ToTitleCase(p.ToLower()))))).ToPagedList(page, 12));
            }
            return View(mr.List("Year").OrderByDescending(x => x.MovieAddDate).Where(x => x.YearId == id).ToPagedList(page, 12));
        }
        public ActionResult MoviePage(int id ,string ye,string ca,string co)
        {
            ViewBag.Id = id;
            return View(mr.List("Category","Year","Country").Where(x => x.MovieId == id));
        }
        public ActionResult MoviePageEN(int id, string ye, string ca, string co)
        {
            ViewBag.Id = id;
            return View(mr.List("Category","Year","Country").Where(x => x.MovieId == id));
        }

        /// Bu Alan Admin Tarafı

        public IActionResult MovieAdminList(int page = 1)
        {
            return View(mr.List("Category","Year","Country").ToPagedList(page,10));
        }
        [HttpGet]
        public IActionResult MovieAdd()
        { 
            return View();
        }
        [HttpPost]
        public IActionResult MovieAdd(Movie m)
        {
            m.MovieAddDate = DateTime.Today;
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
