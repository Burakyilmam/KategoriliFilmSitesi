using CategoryMovieApp.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace CategoryMovieApp.ViewComponents
{
    public class ListCountry : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            CountryRepository cr = new CountryRepository();
            var countrylist = cr.List();
            return View(countrylist);
        }
    }
}
