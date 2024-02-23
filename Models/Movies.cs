using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FilmCollection.Models
{
    public class Movies
    {
        [Key]
        [Required]

        public int MovieId { get; set; }
        [ForeignKey ("CategoryId")]
        public string? CategoryId { get; set; }
        public string Title { get; set; }
        [Range(1888, 2024, ErrorMessage = "Please keep year within 1888 to 2024.")]
        public int Year { get; set; } = 0;
        public string? Director { get; set; }
        public string? Rating { get; set; }
        public bool Edited { get; set; }
        public string? LentTo { get; set; }
        public bool CopiedToPlex { get; set; }
        [MaxLength(25)]
        public string? Notes { get; set; }

    }
}
