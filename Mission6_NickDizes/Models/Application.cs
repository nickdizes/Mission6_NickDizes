using System.ComponentModel.DataAnnotations;

namespace Mission6_NickDizes.Models
{
    public class Application
    {
        [Key]
        public int ApplicationID { get; set; }

        [Required(ErrorMessage = "Category is required")]
        public string Category { get; set; }

        [Required(ErrorMessage = "Title is required")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Year is required")]
        [Range(1800, 3000, ErrorMessage = "Year must be between 1800 and 3000")]
        public int Year { get; set; }

        [Required(ErrorMessage = "Director is required")]
        public string Director { get; set; }

        [Required(ErrorMessage = "Rating is required")]
        public string Rating { get; set; }

        public bool Edited { get; set; }

        public string LentTo { get; set; }

        [MaxLength(25, ErrorMessage = "Notes cannot exceed 25 characters")]
        public string Notes { get; set; }
    }
}