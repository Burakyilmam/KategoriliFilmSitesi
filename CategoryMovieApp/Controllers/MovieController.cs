using CategoryMovieApp.Models;
using CategoryMovieApp.Repositories;
using Microsoft.AspNetCore.Mvc;
using X.PagedList;
using System.Globalization;
using System.Diagnostics.Metrics;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Xml.Linq;
using Microsoft.EntityFrameworkCore;
using System.Linq;

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
                return View(mr.List("Year","Category","Language").Where(x=>(x.MovieNameTR.Contains((CultureInfo.CurrentCulture.TextInfo.ToTitleCase(p.ToLower()))) || (x.MovieNameEN.Contains(CultureInfo.CurrentCulture.TextInfo.ToTitleCase(p.ToLower()))))).ToPagedList(page,12));
            }
            return View(mr.List("Year", "Category", "Language").Where(x => x.MovieAddDate <= DateTime.Now).ToPagedList(page,12));
        }
        public IActionResult MovieListEN(string p, int page = 1)
        {
            if (!string.IsNullOrEmpty(p))
            {
                return View(mr.List("Year", "Category", "Language").Where(x => (x.MovieNameTR.Contains((CultureInfo.CurrentCulture.TextInfo.ToTitleCase(p.ToLower()))) || (x.MovieNameEN.Contains(CultureInfo.CurrentCulture.TextInfo.ToTitleCase(p.ToLower()))))).ToPagedList(page, 12));
            }
            return View(mr.List("Year", "Category", "Language").Where(x => x.MovieAddDate <= DateTime.Now).ToPagedList(page, 12));
        }
        public IActionResult NewAdded(string p , int page = 1)
        {
            if (!string.IsNullOrEmpty(p))
            {
                return View(mr.List("Year","Language","Country","Category").Where(x => (x.MovieNameTR.Contains((CultureInfo.CurrentCulture.TextInfo.ToTitleCase(p.ToLower()))) || (x.MovieNameEN.Contains(CultureInfo.CurrentCulture.TextInfo.ToTitleCase(p.ToLower()))))).ToPagedList(page, 12));
            }
            return View(mr.List("Year", "Language", "Country", "Category").OrderByDescending(x=>x.MovieAddDate).Where(x=>x.MovieAddDate <= DateTime.Now).ToPagedList(page, 12));
        }
        public IActionResult NewAddedEN(string p, int page = 1)
        {
            if (!string.IsNullOrEmpty(p))
            {
                return View(mr.List("Year","Language","Country","Category").Where(x => (x.MovieNameTR.Contains((CultureInfo.CurrentCulture.TextInfo.ToTitleCase(p.ToLower()))) || (x.MovieNameEN.Contains(CultureInfo.CurrentCulture.TextInfo.ToTitleCase(p.ToLower()))))).ToPagedList(page, 12));
            }
            return View(mr.List("Year", "Language", "Country", "Category").OrderByDescending(x => x.MovieAddDate).Where(x => x.MovieAddDate <= DateTime.Now).ToPagedList(page, 12));
        }
        public IActionResult IMDB7(string p, int page = 1)
        {
            if (!string.IsNullOrEmpty(p))
            {
                return View(mr.List("Year", "Language", "Country", "Category").Where(x => (x.MovieNameTR.Contains((CultureInfo.CurrentCulture.TextInfo.ToTitleCase(p.ToLower()))) || (x.MovieNameEN.Contains(CultureInfo.CurrentCulture.TextInfo.ToTitleCase(p.ToLower()))))).ToPagedList(page, 12));
            }
            return View(mr.List("Year", "Language", "Country", "Category").OrderByDescending(x => x.MovieIMDB).Where(x => x.MovieIMDB >= 7).ToPagedList(page, 12));
        }
        public IActionResult IMDB7EN(string p, int page = 1)
        {
            if (!string.IsNullOrEmpty(p))
            {
                return View(mr.List("Year", "Language", "Country", "Category").Where(x => (x.MovieNameTR.Contains((CultureInfo.CurrentCulture.TextInfo.ToTitleCase(p.ToLower()))) || (x.MovieNameEN.Contains(CultureInfo.CurrentCulture.TextInfo.ToTitleCase(p.ToLower()))))).ToPagedList(page, 12));
            }
            return View(mr.List("Year", "Language", "Country", "Category").OrderByDescending(x => x.MovieIMDB).Where(x => x.MovieIMDB >= 7).ToPagedList(page, 12));
        }
        public IActionResult MostComment(string p, int page = 1)
        {
            if (!string.IsNullOrEmpty(p))
            {
                return View(mr.List("Year", "Language", "Country", "Category").Where(x => (x.MovieNameTR.Contains((CultureInfo.CurrentCulture.TextInfo.ToTitleCase(p.ToLower()))) || (x.MovieNameEN.Contains(CultureInfo.CurrentCulture.TextInfo.ToTitleCase(p.ToLower()))))).ToPagedList(page, 12));
            }
            return View(mr.MostComment("Year", "Language", "Country", "Category").ToPagedList(page, 12));
        }
        public IActionResult MostCommentEN(string p, int page = 1)
        {
            if (!string.IsNullOrEmpty(p))
            {
                return View(mr.List("Year", "Language", "Country", "Category").Where(x => (x.MovieNameTR.Contains((CultureInfo.CurrentCulture.TextInfo.ToTitleCase(p.ToLower()))) || (x.MovieNameEN.Contains(CultureInfo.CurrentCulture.TextInfo.ToTitleCase(p.ToLower()))))).ToPagedList(page, 12));
            }
            return View(mr.MostComment("Year", "Language", "Country", "Category").ToPagedList(page, 12));
        }
        public ActionResult GetCategoryMovie(string p ,int id, int page = 1)
        {
            if (!string.IsNullOrEmpty(p))
            {
                return View(mr.List("Year", "Language", "Country", "Category").Where(x => (x.MovieNameTR.Contains((CultureInfo.CurrentCulture.TextInfo.ToTitleCase(p.ToLower()))) || (x.MovieNameEN.Contains(CultureInfo.CurrentCulture.TextInfo.ToTitleCase(p.ToLower()))))).ToPagedList(page, 12));
            }
            return View(mr.List("Year", "Language", "Country", "Category").OrderByDescending(x => x.MovieAddDate).Where(x => x.CategoryId == id).ToPagedList(page, 12));
        }
        public ActionResult GetCategoryMovieEN(string p, int id, int page = 1)
        {
            if (!string.IsNullOrEmpty(p))
            {
                return View(mr.List("Year", "Language", "Country", "Category").Where(x => (x.MovieNameTR.Contains((CultureInfo.CurrentCulture.TextInfo.ToTitleCase(p.ToLower()))) || (x.MovieNameEN.Contains(CultureInfo.CurrentCulture.TextInfo.ToTitleCase(p.ToLower()))))).ToPagedList(page, 12));
            }
            return View(mr.List("Year", "Language", "Country", "Category").OrderByDescending(x => x.MovieAddDate).Where(x => x.CategoryId == id).ToPagedList(page, 12));
        }
        public ActionResult GetCountryMovie(string p, int id, int page = 1)
        {
            if (!string.IsNullOrEmpty(p))
            {
                return View(mr.List("Year", "Language", "Country", "Category").Where(x => (x.MovieNameTR.Contains((CultureInfo.CurrentCulture.TextInfo.ToTitleCase(p.ToLower()))) || (x.MovieNameEN.Contains(CultureInfo.CurrentCulture.TextInfo.ToTitleCase(p.ToLower()))))).ToPagedList(page, 12));
            }
            return View(mr.List("Year", "Language", "Country", "Category").OrderByDescending(x => x.MovieAddDate).Where(x => x.CountryId == id).ToPagedList(page, 12));
        }
        public ActionResult GetCountryMovieEN(string p, int id, int page = 1)
        {
            if (!string.IsNullOrEmpty(p))
            {
                return View(mr.List("Year", "Language", "Country", "Category").Where(x => (x.MovieNameTR.Contains((CultureInfo.CurrentCulture.TextInfo.ToTitleCase(p.ToLower()))) || (x.MovieNameEN.Contains(CultureInfo.CurrentCulture.TextInfo.ToTitleCase(p.ToLower()))))).ToPagedList(page, 12));
            }
            return View(mr.List("Year","Language","Country","Category").OrderByDescending(x => x.MovieAddDate).Where(x => x.CountryId == id).ToPagedList(page, 12));
        }
        public ActionResult GetYearMovie(string p, int id, int page = 1)
        {
            if (!string.IsNullOrEmpty(p))
            {
                return View(mr.List("Year", "Language", "Country", "Category").Where(x => (x.MovieNameTR.Contains((CultureInfo.CurrentCulture.TextInfo.ToTitleCase(p.ToLower()))) || (x.MovieNameEN.Contains(CultureInfo.CurrentCulture.TextInfo.ToTitleCase(p.ToLower()))))).ToPagedList(page, 12));
            }
            return View(mr.List("Year", "Language", "Country", "Category").OrderByDescending(x => x.MovieAddDate).Where(x => x.YearId == id).ToPagedList(page, 12));
        }
        public ActionResult GetYearMovieEN(string p, int id, int page = 1)
        {
            if (!string.IsNullOrEmpty(p))
            {
                return View(mr.List("Year", "Language", "Country", "Category").Where(x => (x.MovieNameTR.Contains((CultureInfo.CurrentCulture.TextInfo.ToTitleCase(p.ToLower()))) || (x.MovieNameEN.Contains(CultureInfo.CurrentCulture.TextInfo.ToTitleCase(p.ToLower()))))).ToPagedList(page, 12));
            }
            return View(mr.List("Year", "Language", "Country", "Category").OrderByDescending(x => x.MovieAddDate).Where(x => x.YearId == id).ToPagedList(page, 12));
        }
        public ActionResult GetLanguageMovie(string p, int id, int page = 1)
        {
            if (!string.IsNullOrEmpty(p))
            {
                return View(mr.List("Year", "Language", "Country", "Category").Where(x => (x.MovieNameTR.Contains((CultureInfo.CurrentCulture.TextInfo.ToTitleCase(p.ToLower()))) || (x.MovieNameEN.Contains(CultureInfo.CurrentCulture.TextInfo.ToTitleCase(p.ToLower()))))).ToPagedList(page, 12));
            }
            return View(mr.List("Year", "Language", "Country", "Category").OrderByDescending(x => x.MovieAddDate).Where(x => x.LanguageId == id).ToPagedList(page, 12));
        }
        public ActionResult GetLanguageMovieEN(string p, int id, int page = 1)
        {
            if (!string.IsNullOrEmpty(p))
            {
                return View(mr.List("Year", "Language", "Country", "Category").Where(x => (x.MovieNameTR.Contains((CultureInfo.CurrentCulture.TextInfo.ToTitleCase(p.ToLower()))) || (x.MovieNameEN.Contains(CultureInfo.CurrentCulture.TextInfo.ToTitleCase(p.ToLower()))))).ToPagedList(page, 12));
            }
            return View(mr.List("Year","Language","Country","Category").OrderByDescending(x => x.MovieAddDate).Where(x => x.LanguageId == id).ToPagedList(page, 12));
        }
        public IActionResult MostView(string p, int page = 1)
        {
            if (!string.IsNullOrEmpty(p))
            {
                return View(mr.List("Year", "Language", "Country", "Category").Where(x => (x.MovieNameTR.Contains((CultureInfo.CurrentCulture.TextInfo.ToTitleCase(p.ToLower()))) || (x.MovieNameEN.Contains(CultureInfo.CurrentCulture.TextInfo.ToTitleCase(p.ToLower()))))).ToPagedList(page, 12));
            }
            return View(mr.List("Year", "Language", "Country", "Category").OrderByDescending(x=>x.MovieViewCount).ToPagedList(page, 12));
        }
        public IActionResult MostViewEN(string p, int page = 1)
        {
            if (!string.IsNullOrEmpty(p))
            {
                return View(mr.List("Year", "Language", "Country", "Category").Where(x => (x.MovieNameTR.Contains((CultureInfo.CurrentCulture.TextInfo.ToTitleCase(p.ToLower()))) || (x.MovieNameEN.Contains(CultureInfo.CurrentCulture.TextInfo.ToTitleCase(p.ToLower()))))).ToPagedList(page, 12));
            }
            return View(mr.List("Year", "Language", "Country", "Category").OrderByDescending(x => x.MovieViewCount).ToPagedList(page, 12));
        }
        public ActionResult MoviePage(int id ,string ye,string ca,string co,string ln)
        {
            var film = mr.Get(id);

            if (film != null)
            {
                film.MovieViewCount++;
                mr.Update(film);
            }
            ViewBag.Id = id;
            return View(mr.List("Category","Year","Country","Language").Where(x => x.MovieId == id));
        }
        public ActionResult MoviePageEN(int id, string ye, string ca, string co , string ln , Movie m)
        {
            var film = mr.Get(id);

            if (film != null)
            {
                film.MovieViewCount++;
                mr.Update(film);
            }
            ViewBag.Id = id;
            
            return View(mr.List("Category","Year","Country","Language").Where(x => x.MovieId == id));
        }

        /// Bu Alan Admin Tarafı

        public IActionResult MovieAdminList(int page = 1)
        {
            return View(mr.List("Category","Year","Country","Language").ToPagedList(page,10));
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
            m.MovieStatu = true;
            mr.Add(m);
            return RedirectToAction("MovieAdminList");
        }
        public IActionResult MovieUpdate(Movie m)
        {
            var movie = mr.Get(m.MovieId);
            movie.MovieNameTR = m.MovieNameTR;
            movie.MovieNameEN = m.MovieNameEN;
            movie.CategoryId = m.CategoryId;
            movie.CountryId = m.CountryId;
            movie.MovieDescription = m.MovieDescription;
            movie.MovieIMDB = m.MovieIMDB;
            movie.MovieImageUrl = m.MovieImageUrl;
            movie.YearId = m.YearId;
            movie.MovieAddDate = m.MovieAddDate;
            movie.LanguageId = m.LanguageId;
            movie.MovieLength = m.MovieLength;
            movie.MovieViewCount = m.MovieViewCount;
            movie.MovieStatu = m.MovieStatu;
            mr.Update(movie);
            return RedirectToAction("MovieAdminList");
        }
        public IActionResult MovieDelete(int id)
        {
            mr.Delete(new Movie { MovieId = id });
            return RedirectToAction("MovieAdminList");
        }
        public IActionResult GetMovie(int id)
        {
            var movie = mr.Get(id);
            Movie m = new Movie()
            {
                MovieId = movie.MovieId,
                MovieNameTR = movie.MovieNameTR,
                MovieNameEN = movie.MovieNameEN,
                CategoryId = movie.CategoryId,
                CountryId = movie.CountryId,
                MovieDescription = movie.MovieDescription,
                MovieIMDB = movie.MovieIMDB,
                MovieImageUrl = movie.MovieImageUrl,
                YearId = movie.YearId,
                MovieAddDate = movie.MovieAddDate,
                LanguageId = movie.LanguageId,
                MovieLength = movie.MovieLength,
                MovieViewCount = movie.MovieViewCount,
                MovieStatu = movie.MovieStatu,
            };
            return View(m);
        }
    }   
}
