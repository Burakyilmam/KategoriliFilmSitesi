using Microsoft.AspNetCore.Mvc;

namespace CategoryMovieApp.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Contact()
        {
            return View();
        }
    }
}
