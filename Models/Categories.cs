using System.ComponentModel.DataAnnotations;

namespace Mission06_Cruz.Models
{
    public class Categories
    {
        [Key]
        [Required]

        public int CategoryId { get; set; }

        public string CategoryName { get; set; }

    }
}
