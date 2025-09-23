using Carpool.Shared;
using Microsoft.EntityFrameworkCore;

namespace Carpool.Server.Data
{
    public class CarpoolDbContext : DbContext
    {
        public CarpoolDbContext(DbContextOptions<CarpoolDbContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }
        public DbSet<DriverProfile> DriverProfiles { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Preis-Spalte präzise definieren
            modelBuilder.Entity<DriverProfile>()
                .Property(dp => dp.Preis)
                .HasPrecision(10, 2); // max 10 Stellen, 2 Nachkommastellen

            base.OnModelCreating(modelBuilder);
        }
    }
}
