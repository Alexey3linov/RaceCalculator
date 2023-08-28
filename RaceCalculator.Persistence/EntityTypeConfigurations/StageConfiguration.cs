using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RaceCalculator.Domain;

namespace RaceCalculator.Persistence.EntityTypeConfigurations
{
    internal class StageConfiguration : BaseConfiguration<Stage>
    {
        public override void Configure(EntityTypeBuilder<Stage> builder)
        {
            base.Configure(builder);
            builder.Property(champ => champ.Title).IsRequired().HasMaxLength(255);
            builder.Property(champ => champ.NominationList);
        }
    }
}
