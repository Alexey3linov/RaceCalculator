using Microsoft.EntityFrameworkCore;

using RaceCalculator.Domain;

namespace RaceCalculator.Application.Interfaces
{
    public interface IChampionshipDbContext
    {
        DbSet<Championship> Championships { get; set; }
        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}
