using System.ComponentModel.DataAnnotations;

namespace TizzelMovies.Web.Models
{
    public class Movie
    {
        public int ID { get; set; }
        public string? Title { get; set; }
        [DataType(DataType.Date)]
        [Display(Name = "Release Date")]
        public DateOnly ReleaseDate { get; set; }
        public string? Genre { get; set; }
        public decimal Price { get; set; }
    }
}
