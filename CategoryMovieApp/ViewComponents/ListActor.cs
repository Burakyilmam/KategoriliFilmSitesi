using CategoryMovieApp.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace CategoryMovieApp.ViewComponents
{
    public class ListActor : ViewComponent
    {
        public IViewComponentResult Invoke(int id)
        {
            ActorRepository ar = new ActorRepository();
            var actorlist = ar.List().Where(x => x.ActorStatu == true).OrderByDescending(x => x.ActorTitle).Where(x => x.MovieId == id);
            return View(actorlist);
        }
    }
}
