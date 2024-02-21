using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mission06_Martin.Models
{
    public class Categories
    {
        [Key]
        [Required]
        public int CategoryId { get; set; }
        [Required]
        public string Category { get; set; }

    }
}
