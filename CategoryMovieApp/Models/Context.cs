using Microsoft.EntityFrameworkCore;

namespace CategoryMovieApp.Models
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-EVJH8OQ;database=CategoryMovieAppDB;integrated security=true");
        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Movie> Movies { get; set; }
    }
}
