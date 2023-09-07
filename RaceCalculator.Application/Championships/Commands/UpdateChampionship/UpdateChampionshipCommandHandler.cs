using MediatR;

using Microsoft.EntityFrameworkCore;

using RaceCalculator.Application.Common.Exceptions;
using RaceCalculator.Application.Interfaces;
using RaceCalculator.Domain;

namespace RaceCalculator.Application.Championships.Commands.UpdateChampionship
{
    public class UpdateChampionshipCommandHandler : IRequestHandler<UpdateChampionshipCommand, Guid>
    {
        private readonly IChampionshipDbContext _dbContext;

        public UpdateChampionshipCommandHandler(IChampionshipDbContext dbContext) => _dbContext = dbContext;

        public async Task<Guid> Handle(UpdateChampionshipCommand request, CancellationToken token)
        {
            var entity = await _dbContext.Championships.FirstOrDefaultAsync(c => c.Id == request.Id, token);

            if (entity == null)
            {
                throw new NotFoundException(nameof(Championship), request.Id);
            }

            entity.Title          = request.Title;
            entity.StartDate      = request.StartDate;
            entity.StageList      = request.StageList;
            entity.NominationList = request.NominationList;
            entity.CompetitorList = request.CompetitorList;

            await _dbContext.SaveChangesAsync(token);

            return default;
        }
    }
}
