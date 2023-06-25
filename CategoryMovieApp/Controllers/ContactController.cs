using CategoryMovieApp.Models;
using CategoryMovieApp.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace CategoryMovieApp.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Contact()
        {
            return View();
        }
        public PartialViewResult ContactAdd(int id)
        {
            ViewBag.Id = id;
            return PartialView();
        }
        [HttpPost]
        public IActionResult ContactAdd(Contact c)
        {   ContactRepository cr = new ContactRepository();
            c.ContactDate = DateTime.Today;
            c.ContactStatu = true;
            cr.Add(c);
            return RedirectToAction("Contact", "Contact");

        }
    }
}
