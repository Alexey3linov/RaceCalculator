using MediatR;

using Microsoft.EntityFrameworkCore;

using RaceCalculator.Application.Interfaces;

namespace RaceCalculator.Application.Championships.Commands.UpdateChampionship
{
    public class UpdateChampionshipCommandHandler : IRequestHandler<UpdateChampionshipCommand, Guid>
    {
        private readonly IChampionshipDbContext _dbContext;

        public UpdateChampionshipCommandHandler(IChampionshipDbContext dbContext) => _dbContext = dbContext;

        public async Task<Guid> Handle(UpdateChampionshipCommand request, CancellationToken token)
        {
            var entity = _dbContext.Championships.FirstOrDefaultAsync(c => c.Id == request.Id, token);

            if (entity == null)
            {
                throw
            }

            return default;
        }
    }
}
