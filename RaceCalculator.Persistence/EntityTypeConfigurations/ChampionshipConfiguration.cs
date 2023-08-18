using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

using RaceCalculator.Domain;

namespace RaceCalculator.Persistence.EntityTypeConfigurations
{
    public class ChampionshipConfiguration : IEntityTypeConfiguration<Championship>
    {
        public void Configure(EntityTypeBuilder<Championship> builder)
        {
            builder.HasKey(champ   => champ.Id);
            builder.HasIndex(champ => champ.Id).IsUnique();
            builder.Property(champ => champ.Title).IsRequired().HasMaxLength(255);
            builder.Property(champ => champ.StartDate).IsRequired();
        }
    }
}
