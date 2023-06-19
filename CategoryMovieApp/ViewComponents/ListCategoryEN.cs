using CategoryMovieApp.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace CategoryMovieApp.ViewComponents
{
    public class ListCategoryEN : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            CategoryRepository cr = new CategoryRepository();
            var categorylist = cr.List().Where(x => x.CategoryStatu == true).OrderBy(x => x.CategoryNameEN); ;
            return View(categorylist);
        }
    }
}
