using System.ComponentModel.DataAnnotations;

namespace CategoryMovieApp.Models
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }
        public string CategoryNameTR { get; set; }
        public string CategoryNameEN { get; set; }
        public List<Movie> Movies { get; set; }
    }
}
