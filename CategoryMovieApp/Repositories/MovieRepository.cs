using CategoryMovieApp.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace CategoryMovieApp.Repositories
{
    public class MovieRepository : GenericRepository<Movie>
    {
        Context c = new Context();
        public List<Movie> MostComment(string y)
        {
            return c.Set<Movie>().Include(y).OrderByDescending(x => x.Comments.Count()).ToList();
        }
    }
}
