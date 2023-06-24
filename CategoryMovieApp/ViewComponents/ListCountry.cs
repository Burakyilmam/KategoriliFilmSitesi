using CategoryMovieApp.Repositories;
using Microsoft.AspNetCore.Mvc;
using X.PagedList;

namespace CategoryMovieApp.ViewComponents
{
    public class ListCountry : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            CountryRepository cr = new CountryRepository();
            var countrylist = cr.List().Where(x => x.CountryStatu == true).OrderBy(x => x.CountryNameTR);
            return View(countrylist);
        }
    }
}
