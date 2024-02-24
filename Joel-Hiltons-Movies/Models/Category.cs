using System.ComponentModel.DataAnnotations;

namespace Joel_Hiltons_Movies.Models
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
    }
}
