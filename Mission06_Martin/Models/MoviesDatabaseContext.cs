using Microsoft.EntityFrameworkCore;

namespace Mission06_Martin.Models
{
    public class MoviesDatabaseContext : DbContext
    {
        public MoviesDatabaseContext(DbContextOptions<MoviesDatabaseContext> options) : base (options) 
        { 
        }

        public DbSet<Movie> Movies { get; set; }
        public DbSet<Categories> Categories { get; set; }

    }
}
