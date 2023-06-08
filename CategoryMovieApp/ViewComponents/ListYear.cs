using CategoryMovieApp.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace CategoryMovieApp.ViewComponents
{
    public class ListYear : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            YearRepository yr = new YearRepository();
            var yearlist = yr.List();
            return View(yearlist);
        }
    }
}
