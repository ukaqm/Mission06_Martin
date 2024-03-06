using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mission06_Martin.Models
{
    public class Movie
    {
        [Key]
        [Required]
        public int MovieId { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        [Range(1888, int.MaxValue, ErrorMessage = "Please enter a valid year. (1888 to current year)")]
        public string Year { get; set; } 

        public string? Director { get; set; }

        public string? Rating { get; set; }

        public string? LentTo { get; set; }

        [Required]
        public bool Edited { get; set; }

        [Required]
        public bool CopiedToPlex { get; set; }

        public string? Notes { get; set; }

        [ForeignKey("Categories")]
        public int? CategoryId { get; set; }

        public Category? Category { get; set; }




    }

}
