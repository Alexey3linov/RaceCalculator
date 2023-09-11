using System.Runtime.CompilerServices;

using Microsoft.EntityFrameworkCore;

using RaceCalculator.Application.Interfaces;

namespace RaceCalculator.Persistence
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddPersistence(this IServiceCollection services, IConfiguration configuration)
        {
            var connectionString = configuration["DbConnection"];
            services.AddDbContext<ChampionshipDbContext>(options =>
            {
                options.UseSqlite(connectionString);
            });
            services.AddScoped<IChampionshipDbContext>(provider => provider.GetService<ChampionshipDbContext>()!);
            return services;
        }
    }
}
