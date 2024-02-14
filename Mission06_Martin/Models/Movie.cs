using System.ComponentModel.DataAnnotations;

namespace Mission06_Martin.Models
{
    public class Movie
    {
        [Key]
        [Required(ErrorMessage = "Movie ID is required.")]
        public int movieID { get; set; }

        [Required(ErrorMessage = "Movie category is required.")]
        public string movieCategory { get; set; }

        [Required(ErrorMessage = "Movie title is required.")]
        public string movieTitle { get; set; }

        [Required(ErrorMessage = "Movie year is required.")]
        [Range(1900, 2100, ErrorMessage = "Year must be between 1900 and 2100.")]
        public int movieYear { get; set; }

        [Required(ErrorMessage = "Movie director is required.")]
        public string movieDirector { get; set; }

        [Required(ErrorMessage = "Movie rating is required.")]
        [RegularExpression("(G|PG|PG-13|R)", ErrorMessage = "Invalid rating. Valid ratings are: G, PG, PG-13, R.")]
        public string movieRating { get; set; }

        public string? movieLentTo { get; set; }

        public bool? movieEdited { get; set; }

        [StringLength(25, ErrorMessage = "Notes cannot be more than 25 characters long.")]
        public string? movieNotes { get; set; }
    }

}
