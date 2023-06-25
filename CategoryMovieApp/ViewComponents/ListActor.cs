using CategoryMovieApp.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace CategoryMovieApp.ViewComponents
{
    public class ListActor : ViewComponent
    {
        public IViewComponentResult Invoke(int id)
        {
            ActorRepository ar = new ActorRepository();
            var actorlist = ar.List().Where(x => x.ActorStatu == true).OrderBy(x => x.ActorName).Where(x => x.MovieId == id);
            return View(actorlist);
        }
    }
}
