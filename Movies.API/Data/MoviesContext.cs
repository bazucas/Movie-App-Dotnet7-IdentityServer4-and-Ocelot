using Microsoft.EntityFrameworkCore;

namespace Movies.API.Data
{
    public class MoviesContext : DbContext
    {
        public MoviesContext(DbContextOptions<MoviesContext> options)
            : base(options)
        {
        }

        public DbSet<Model.Movie> Movie { get; set; } = default!;
    }
}
