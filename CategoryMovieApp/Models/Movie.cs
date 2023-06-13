using System.ComponentModel.DataAnnotations;

namespace CategoryMovieApp.Models
{
    public class Movie
    {
        [Key]
        public int MovieId { get; set; }
        public string MovieNameTR { get; set; }
        public string MovieNameEN { get; set; }
        public string MovieDescription { get; set; }
        public string MovieImageUrl { get; set; }
        public string MovieBadge { get; set; }
        public float MovieIMDB { get; set; }
        public DateTime MovieAddDate { get; set; }
        public bool MovieStatu = true;
        public int CategoryId { get; set; }
        public List<Comment> Comments { get; set; }
        public virtual Category Category { get; set; }
        public int YearId { get; set; }
        public virtual Year Year { get; set; }
        public int CountryId { get; set; }
        public virtual Country Country { get; set; }
    }
}
