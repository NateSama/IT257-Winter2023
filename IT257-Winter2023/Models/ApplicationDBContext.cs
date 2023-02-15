using IT257_Winter2023.Models.Games;
using IT257_Winter2023.Models.Ratings;
using Microsoft.EntityFrameworkCore;

namespace IT257_Winter2023.Models
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options): base(options) {

        }
        public DbSet<GenreModel> Genres { get; set; }
        public DbSet<ConsoleModel> Consoles { get; set; }
        public DbSet<RatingsProvider> RatingsProviders { get; set; }
        public DbSet<Rating> Ratings { get; set; }
        public DbSet<GameModel> Games { get; set; }

    }
}
