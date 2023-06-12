using CategoryMovieApp.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace CategoryMovieApp.ViewComponents
{
    public class ListCategory : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            CategoryRepository cr = new CategoryRepository();
            var categorylist = cr.List().Where(x => x.CategoryStatu == true);
            return View(categorylist);
        }
    }
}
