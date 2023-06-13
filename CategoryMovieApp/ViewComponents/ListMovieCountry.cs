using CategoryMovieApp.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace CategoryMovieApp.ViewComponents
{
    public class ListMovieCountry : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            CountryRepository cr = new CountryRepository();
            var countrylist = cr.List().Where(x => x.CountryStatu == true).OrderBy(x => x.CountryName); ;
            return View(countrylist);
        }
    }
}
