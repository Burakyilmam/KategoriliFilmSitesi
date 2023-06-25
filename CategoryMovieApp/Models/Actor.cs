using System.ComponentModel.DataAnnotations;

namespace CategoryMovieApp.Models
{
    public class Actor
    {
        [Key]
        public int ActorId { get; set; }
        public string ActorName { get; set; }
        public string ActorTitle { get; set; }
        public string ActorImageUrl { get; set; }
        public bool ActorStatu { get; set; }
        public int MovieId { get; set; }
        public Movie Movie { get; set; }
    }
}
