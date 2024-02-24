using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Joel_Hiltons_Movies.Models
{
    public class Application
    {
        // This model defines what type of data is going into the database

        [Key]
        [Required]
        public int MovieId { get; set; }

        [ForeignKey("Category")]
        public int? CategoryId { get; set; }
        public Category? Category { get; set; }
        public string Title { get; set; }
        [Range(1888, 2025,ErrorMessage = "You must enter a valid year.")]
        public int Year { get; set; }
        public string? Director { get; set; }
        public string? Rating { get; set; }
        [Required(ErrorMessage = "You need to specify if it is edited.")]
        public bool Edited { get; set; }
        public string? lent_to { get; set; }
        [Required(ErrorMessage = "You need to specify if it is copied to Plex.")]
        public bool CopiedToPlex { get; set; }
        public string? notes { get; set; }
    }
}
