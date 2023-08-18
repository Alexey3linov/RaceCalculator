namespace RaceCalculator.Persistence
{
    public class DbInitializer
    {
        public static void Initialize(ChampionshipDbContext context)
        {
            context.Database.EnsureCreated();
        }
    }
}
