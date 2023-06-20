using Microsoft.EntityFrameworkCore;

namespace CategoryMovieApp.Models
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-EVJH8OQ;database=CategoryMovieAppDB2;integrated security=true");
        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Year> Years { get; set; }
        public DbSet<Language> Languages { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Movie> Movies { get; set; }
    }
}
