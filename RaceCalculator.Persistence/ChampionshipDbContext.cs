using Microsoft.EntityFrameworkCore;

using RaceCalculator.Persistence.EntityTypeConfigurations;
using RaceCalculator.Application.Interfaces;
using RaceCalculator.Domain;

namespace RaceCalculator.Persistence
{
    public class ChampionshipDbContext : DbContext, IChampionshipDbContext
    {
        public DbSet<Championship> Championships { get; set; }

        public ChampionshipDbContext(DbContextOptions<ChampionshipDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ChampionshipConfiguration());
            base.OnModelCreating(modelBuilder);
        }
    }
}
