using System.ComponentModel.DataAnnotations;

namespace Joel_Hiltons_Movies.Models
{
    public class Application
    {
        [Key]
        [Required]
        public int MovieID { get; set; }
        public string category { get; set; }
        public string title { get; set; }
        public int year { get; set; }
        public string director { get; set; }
        public string rating { get; set; }
        public bool edited { get; set; }
        public string lent_to { get; set; }
        public string notes { get; set; }
    }
}
