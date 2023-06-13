using CategoryMovieApp.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace CategoryMovieApp.ViewComponents
{
    public class ListMovieYear : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            YearRepository yr = new YearRepository();
            var yearlist = yr.List().Where(x => x.YearStatu == true).OrderBy(x => x.YearName); ;
            return View(yearlist);
        }
    }
}
