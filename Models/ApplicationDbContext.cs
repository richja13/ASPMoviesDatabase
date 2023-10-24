using Microsoft.EntityFrameworkCore;

namespace MoviesInfoApp.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Movie> movies{get;set;}
    }
}
