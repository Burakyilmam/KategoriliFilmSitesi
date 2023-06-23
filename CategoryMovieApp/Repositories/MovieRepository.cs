using CategoryMovieApp.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace CategoryMovieApp.Repositories
{
    public class MovieRepository : GenericRepository<Movie>
    {
        Context c = new Context();

        public List<Movie> MostComment(string ca, string ye, string co, string ln)
        {
            return c.Set<Movie>().Include(ca).Include(ye).Include(co).Include(ln).OrderByDescending(x=>x.Comments.Count).ToList();
        }
    }
}