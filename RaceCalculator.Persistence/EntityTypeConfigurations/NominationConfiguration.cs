using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RaceCalculator.Domain;

namespace RaceCalculator.Persistence.EntityTypeConfigurations
{
    internal class NominationConfiguration : BaseConfiguration<Nomination>
    {
        public override void Configure(EntityTypeBuilder<Nomination> builder)
        {
            base.Configure(builder);
            builder.Property(champ => champ.Title).IsRequired().HasMaxLength(255);
        }
    }
}
