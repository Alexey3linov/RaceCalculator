using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RaceCalculator.Domain;

namespace RaceCalculator.Persistence.EntityTypeConfigurations
{
    internal class CompetitorConfiguration : BaseConfiguration<Competitor>
    {
        public override void Configure(EntityTypeBuilder<Competitor> builder)
        {
            base.Configure(builder);
            builder.Property(champ => champ.Name).IsRequired().HasMaxLength(255);
            builder.Property(champ => champ.Class).IsRequired();
        }
    }
}
