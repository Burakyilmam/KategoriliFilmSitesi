using CategoryMovieApp.Models;
using CategoryMovieApp.Repositories;
using Microsoft.AspNetCore.Mvc;
using X.PagedList;

namespace CategoryMovieApp.Controllers
{
    public class CountryController : Controller
    {
        CountryRepository cr = new CountryRepository();
        public IActionResult CountryList(int page = 1)
        {
            return View(cr.List().ToPagedList(page, 10));
        }
        [HttpGet]
        public IActionResult CountryAdd()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CountryAdd(Country c)
        {
            c.CountryStatu = true;
            cr.Add(c);
            return RedirectToAction("CountryList");
        }
        public IActionResult CountryUpdate(Country c)
        {
            var Country = cr.Get(c.CountryId);
            Country.CountryNameTR = c.CountryNameTR;
            Country.CountryNameEN = c.CountryNameEN;
            Country.CountryStatu = c.CountryStatu;
            Country.CountryId = c.CountryId;
            cr.Update(Country);
            return RedirectToAction("CountryList");
        }
        public IActionResult CountryDelete(int id)
        {
            cr.Delete(new Country { CountryId = id });
            return RedirectToAction("CountryList");
        }
        public IActionResult GetCountry(int id)
        {
            var Country = cr.Get(id);
            Country c = new Country()
            {
                CountryId = Country.CountryId,
                CountryNameTR = Country.CountryNameTR,
                CountryNameEN = Country.CountryNameEN,
                CountryStatu = Country.CountryStatu,
            };
            return View(c);
        }
    }
}
