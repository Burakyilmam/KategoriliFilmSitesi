using System.ComponentModel.DataAnnotations;

namespace CategoryMovieApp.Models
{
    public class Admin
    {
        [Key]
        public int AdminId { get; set; }
        public string AdminName { get; set; }
        public string AdminPassword { get; set; }
        public bool AdminStatu { get; set; }
    }
}
