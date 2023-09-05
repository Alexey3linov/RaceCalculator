using MediatR;

using RaceCalculator.Application.Interfaces;
using RaceCalculator.Domain;

namespace RaceCalculator.Application.Championships.Commands.CreateChampionship
{
    public class CreateChampionshipCommandHandler : IRequestHandler<CreateChampionshipCommand, Guid>
    {
        private readonly IChampionshipDbContext _dbContext;

        public CreateChampionshipCommandHandler(IChampionshipDbContext dbContext) => _dbContext = dbContext;

        public async Task<Guid> Handle(CreateChampionshipCommand request, CancellationToken token)
        {
            var championship = new Championship
            {
                Id             = new Guid(),
                Title          = request.Title,
                StartDate      = request.StartDate,
                StageList      = request.StageList,
                NominationList = request.NominationList,
                CompetitorList = request.CompetitorList
            };

            await _dbContext.Championships.AddAsync(championship, token);
            await _dbContext.SaveChangesAsync(token);

            return championship.Id;
        }
    }
}
