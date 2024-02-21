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
        public string Year { get; set; }

        [Required]
        public string Director { get; set; }

        [Required]
        public string Rating { get; set; }

        public string? LentTo { get; set; }

        public bool? Edited { get; set; }

        public string? Notes { get; set; }

        [ForeignKey("CategoryId")]
        public string Category { get; set; }



    }

}
