using System.ComponentModel.DataAnnotations;

namespace CategoryMovieApp.Models
{
    public class Country
    {
        [Key]
        public int CountryId { get; set; }
        public string CountryNameTR { get; set; }
        public string CountryNameEN { get; set; }
        public bool CountryStatu { get; set; }
        public List<Movie> Movies { get; set; }
    }
}
