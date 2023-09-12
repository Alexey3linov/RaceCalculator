using System.Reflection;

using RaceCalculator.Application;
using RaceCalculator.Application.Common.Mappings;
using RaceCalculator.Application.Interfaces;
using RaceCalculator.Persistence;

var builder = WebApplication.CreateBuilder(args);
var app     = builder.Build();

using (var scope = app.Services.CreateScope())
{
    var serviceProvider = scope.ServiceProvider;
    try
    {
        var context = serviceProvider.GetRequiredService<ChampionshipDbContext>();
        DbInitializer.Initialize(context);
    }
    catch (Exception exception)
    {

    }
}

app.Run();

builder.Services.AddAutoMapper(config =>
{
    config.AddProfile(new AssemblyMappingProfile(Assembly.GetExecutingAssembly()));
    config.AddProfile(new AssemblyMappingProfile(typeof(IChampionshipDbContext).Assembly));
});

builder.Services.AddApplication();
builder.Services.AddPersistence(builder.Configuration.Get<IConfiguration>());
