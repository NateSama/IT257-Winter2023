using IT257_Winter2023.Models.Games;
using IT257_Winter2023.Models.Ratings;
using Microsoft.EntityFrameworkCore;

namespace IT257_Winter2023.Models
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) 
            : base(options)
        {

        }
        public DbSet<GenreModel> Genres { get; set; }
        public DbSet<ConsoleModel> Consoles { get; set; }
        public DbSet<RatingsProvider> RatingsProviders { get; set; }
        public DbSet<Rating> Ratings { get; set; }
        public DbSet<GameModel> Games { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Setting Foreign Keys and Relations
            modelBuilder.Entity<GameModel>()
                .HasOne(g => g.Genre)
                .WithMany(g => g.Games)
                .HasForeignKey(g => g.GenreId);

            modelBuilder.Entity<GameModel>()
                .HasOne(g => g.Console)
                .WithMany(g => g.Games)
                .HasForeignKey(g => g.ConsoleId);

            modelBuilder.Entity<Rating>()
                .HasOne(r => r.Provider)
                .WithMany(g => g.Ratings)
                .HasForeignKey(r => r.GameId);

            modelBuilder.Entity<Rating>()
                .HasOne(r => r.Provider)
                .WithMany(p => p.Ratings)
                .HasForeignKey(r => r.ProviderID);

            //Setting AutoIncrement

            modelBuilder.Entity<GenreModel>()
                .HasKey(gr => gr.GenreId)
                .ForSqlServerIsClustered(false);

            modelBuilder.Entity<GenreModel>()
                .Property(gr => gr.GenreId)
                .ValueGeneratedOnAdd();

            modelBuilder.Entity<ConsoleModel>()
                .HasKey(c => c.ConsoleId)
                .ForSqlServerIsClustered(false);

            modelBuilder.Entity<ConsoleModel>()
                .Property(c => c.ConsoleId)
                .ValueGeneratedOnAdd();

            modelBuilder.Entity<GameModel>()
                .HasKey(g => g.Id)
                .ForSqlServerIsClustered(false);

            modelBuilder.Entity<GameModel>()
                .Property(g => g.Id)
                .ValueGeneratedOnAdd();

        }
    }
}
