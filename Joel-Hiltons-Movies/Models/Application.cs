using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Joel_Hiltons_Movies.Models
{
    public class Application
    {
        // This model defines what type of data is going into the database

        [Key]
        [Required]
        public int MovieID { get; set; }

        [ForeignKey("CategoryID")]
        public int CategoryID { get; set; }
        public Category category { get; set; }
        public string title { get; set; }
        public int year { get; set; }
        public string director { get; set; }
        public string rating { get; set; }
        public bool? edited { get; set; }
        public string? lent_to { get; set; }
        public string? notes { get; set; }
    }
}
