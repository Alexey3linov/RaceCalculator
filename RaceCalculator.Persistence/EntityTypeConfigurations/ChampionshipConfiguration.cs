using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RaceCalculator.Domain;

namespace RaceCalculator.Persistence.EntityTypeConfigurations
{
    internal class ChampionshipConfiguration : BaseConfiguration<Championship>
    {
        public override void Configure(EntityTypeBuilder<Championship> builder)
        {
            base.Configure(builder);
            builder.Property(champ => champ.Title).IsRequired().HasMaxLength(255);
            builder.Property(champ => champ.StartDate).IsRequired();
            builder.Property(champ => champ.StageList).IsRequired();
            builder.Property(champ => champ.NominationList).IsRequired();
            builder.Property(champ => champ.CompetitorList);
            builder.Property(champ => champ.StageCount);
        }
    }
}
