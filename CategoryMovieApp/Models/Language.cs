using System.ComponentModel.DataAnnotations;

namespace CategoryMovieApp.Models
{
    public class Language
    {
        [Key]
        public int LanguageId { get; set; }
        public string LanguageNameTR { get; set; }
        public string LanguageNameEN { get; set; }
        public bool LanguageStatu { get; set; }
        public List<Movie> Movies { get; set; }
    }
}

