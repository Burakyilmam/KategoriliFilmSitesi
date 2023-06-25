using System.ComponentModel.DataAnnotations;

namespace CategoryMovieApp.Models
{
    public class Contact
    {
        [Key]
        public int ContactId { get; set; }
        public string ContactText { get; set; }
        public string ContactName { get; set; }
        public string ContactPhone { get; set; }
        public DateTime ContactDate { get; set; }
        public bool ContactStatu { get; set; }
    }
}
