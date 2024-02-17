using Microsoft.EntityFrameworkCore;

namespace Joel_Hiltons_Movies.Models
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options) // Constructor
        { 
        }
        public DbSet<Application> JoelsMovies { get; set; }

    }
}
