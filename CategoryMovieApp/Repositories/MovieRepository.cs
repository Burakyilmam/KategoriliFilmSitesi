using CategoryMovieApp.Models;

namespace CategoryMovieApp.Repositories
{
    public class MovieRepository : GenericRepository<Movie>
    {
        Context c = new Context();
        public List<Movie> MostComment()
        {
            return c.Set<Movie>().OrderByDescending(x => x.Comments.Count()).ToList();
        }
    }
}
