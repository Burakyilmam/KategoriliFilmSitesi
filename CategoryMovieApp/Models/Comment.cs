using System.ComponentModel.DataAnnotations;

namespace CategoryMovieApp.Models
{
    public class Comment
    {
        [Key]
        public int CommentId { get; set; }
        public string CommentText { get; set; }
        public DateTime CommentDate { get; set; }
        public int CommentLike { get; set; }
        public int MovieId { get; set; }
        public virtual Movie Movie { get; set; }
        public int UserId { get; set; }
        public virtual User User { get; set; }
    }
}
