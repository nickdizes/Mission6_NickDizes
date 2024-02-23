using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.Eventing.Reader;

namespace Mission6_NickDizes.Models
{
    public class Movie
    {
        [Key]
        public int MovieId { get; set; }

        [ForeignKey("CategoryId")]
        public int? CategoryId { get; set; }
        public Category? Category { get; set; }

        [Required(ErrorMessage = "Title is required")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Year is required")]
        [Range(1888, 2025, ErrorMessage = "Year must be between 1800 and 2025")]
        public int Year { get; set; }

        public string? Director { get; set; }

        public string? Rating { get; set; }

        [Required(ErrorMessage = "Edited is required")]
        public bool Edited { get; set; }

        public string? LentTo { get; set; }

        [Required(ErrorMessage = "Copied To Plex is required")]
        public bool CopiedToPlex { get; set; }

        [MaxLength(25, ErrorMessage = "Notes cannot exceed 25 characters")]
        public string? Notes { get; set; }
    }
}