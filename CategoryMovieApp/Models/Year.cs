using System.ComponentModel.DataAnnotations;

namespace CategoryMovieApp.Models
{
    public class Year
    {
        [Key]
        public int YearId { get; set; }
        public string YearName { get; set; }
        public bool YearStatu { get; set; }
        public List<Movie> Movies { get; set; }
    }
}
