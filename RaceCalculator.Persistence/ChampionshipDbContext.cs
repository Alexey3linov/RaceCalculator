using Microsoft.EntityFrameworkCore;

using RaceCalculator.Persistence.EntityTypeConfigurations;
using RaceCalculator.Application.Interfaces;
using RaceCalculator.Domain;

namespace RaceCalculator.Persistence
{
    public class ChampionshipDbContext : DbContext, IChampionshipDbContext
    {
        public DbSet<Championship> Championships { get; set; }
        public DbSet<Competitor>   Competitors   { get; set; }
        public DbSet<Nomination>   Nominations   { get; set; }
        public DbSet<Stage>        Stages        { get; set; }

        public ChampionshipDbContext(DbContextOptions<ChampionshipDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ChampionshipConfiguration());
            modelBuilder.ApplyConfiguration(new CompetitorConfiguration());
            modelBuilder.ApplyConfiguration(new NominationConfiguration());
            modelBuilder.ApplyConfiguration(new StageConfiguration());
            base.OnModelCreating(modelBuilder);
        }
    }
}
