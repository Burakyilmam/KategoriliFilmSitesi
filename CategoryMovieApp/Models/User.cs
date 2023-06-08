using System.ComponentModel.DataAnnotations;

namespace CategoryMovieApp.Models
{
    public class User
    {
        [Key]
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string UserPassword { get; set; }
        public bool UserStatu { get; set; }
        public List<Comment> Comments { get; set; }
    }
}
