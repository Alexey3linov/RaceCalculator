using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

using RaceCalculator.Domain;

namespace RaceCalculator.Persistence.EntityTypeConfigurations
{
    public class BaseConfiguration<TEntity> : IEntityTypeConfiguration<TEntity> where TEntity : BaseEntity
    {
        public virtual void Configure(EntityTypeBuilder<TEntity> builder)
        {
            builder.HasKey(champ   => champ.Id);
            builder.HasIndex(champ => champ.Id).IsUnique();
        }
    }
}
