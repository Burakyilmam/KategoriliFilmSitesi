using CategoryMovieApp.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace CategoryMovieApp.ViewComponents
{
    public class ListLanguageNoComment : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            LanguageRepository lr = new LanguageRepository();
            var languagelist = lr.List().Where(x => x.LanguageStatu == true).OrderBy(x => x.LanguageNameTR); ;
            return View(languagelist);
        }
    }
}
