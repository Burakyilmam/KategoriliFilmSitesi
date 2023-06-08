using CategoryMovieApp.Models;

namespace CategoryMovieApp.Repositories
{
    public class MovieRepository : GenericRepository<Movie>
    {
        Context c = new Context();
        public List<Movie> NewAddedList()
        {
            return c.Set<Movie>().OrderByDescending(x=>x.MovieAddDate).Where(x=>x.MovieAddDate<=DateTime.Now).ToList();
        }
        public List<Movie> IMDB7()
        {
            return c.Set<Movie>().OrderByDescending(x => x.MovieAddDate).Where(x => x.MovieIMDB >= 7).ToList();
        }
        public List<Movie> MostComment()
        {
            return c.Set<Movie>().OrderByDescending(x => x.Comments.Count).ToList();
        }
    }
}
