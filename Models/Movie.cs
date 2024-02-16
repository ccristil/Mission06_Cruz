using System.ComponentModel.DataAnnotations;

namespace FilmCollection.Models
{
    public class Movie
    {
        [Key]
        [Required]

        public int id { get; set; }
        public string category { get; set; }
        public string title { get; set; }
        public int year { get; set; }
        public string director { get; set; }
        public string rating { get; set; }
        public bool edited { get; set; }
        public string? lent { get; set; }
        [MaxLength(25)]
        public string? notes { get; set; }

    }
}
