using CategoryMovieApp.Models;
using CategoryMovieApp.Repositories;
using Microsoft.AspNetCore.Mvc;
using X.PagedList;

namespace CategoryMovieApp.Controllers
{
    public class YearController : Controller
    {
        YearRepository yr = new YearRepository();
        public IActionResult YearList(int page = 1)
        {
            return View(yr.List().ToPagedList(page, 10));
        }
        [HttpGet]
        public IActionResult YearAdd()
        {
            return View();
        }
        [HttpPost]
        public IActionResult YearAdd(Year y)
        {
            y.YearStatu = true;
            yr.Add(y);
            return RedirectToAction("YearList");
        }
        public IActionResult YearUpdate(Year y)
        {
            var year = yr.Get(y.YearId);
            year.YearName = y.YearName;
            year.YearStatu = y.YearStatu;
            year.YearId = y.YearId;
            yr.Update(year);
            return RedirectToAction("YearList");
        }
        public IActionResult YearDelete(int id)
        {
            yr.Delete(new Year { YearId= id });
            return RedirectToAction("YearList");
        }
        public IActionResult GetYear(int id)
        {
            var year = yr.Get(id);
            Year y = new Year()
            {
                YearId = year.YearId,
                YearName = year.YearName,
                YearStatu = year.YearStatu,
            };
            return View(y);
        }
    }
}
