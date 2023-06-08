using System.ComponentModel.DataAnnotations;

namespace CategoryMovieApp.Models
{
    public class Country
    {
        [Key]
        public int CountryId { get; set; }
        public string CountryName { get; set; }
        public bool CountryStatu { get; set; }
        public List<Movie> Movies { get; set; }
    }
}
