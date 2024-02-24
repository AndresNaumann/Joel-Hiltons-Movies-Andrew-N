using Microsoft.EntityFrameworkCore;

// DBContext page

namespace Joel_Hiltons_Movies.Models
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options) // Constructor
        { 
        }
        public DbSet<Application> JoelsMovies { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder) // Seed Data
        {
            modelBuilder.Entity<Category>().HasData(

                new Category { CategoryID = 1, CategoryName = "Miscellaneous" },
                new Category { CategoryID = 2, CategoryName = "Drama" },
                new Category { CategoryID = 3, CategoryName = "Television" },
                new Category { CategoryID = 4, CategoryName = "Horror/Suspense" },
                new Category { CategoryID = 5, CategoryName = "Comedy" },
                new Category { CategoryID = 6, CategoryName = "Family" },
                new Category { CategoryID = 7, CategoryName = "Action/Adventure" },
                new Category { CategoryID = 8, CategoryName = "VHS" }

            );
        }

    }
}
