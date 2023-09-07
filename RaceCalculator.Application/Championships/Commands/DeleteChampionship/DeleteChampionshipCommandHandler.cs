using MediatR;

using Microsoft.EntityFrameworkCore;

using RaceCalculator.Application.Common.Exceptions;
using RaceCalculator.Application.Interfaces;
using RaceCalculator.Domain;

namespace RaceCalculator.Application.Championships.Commands.DeleteChampionship
{
    public class DeleteChampionshipCommandHandler : IRequestHandler<DeleteChampionshipCommand, Guid>
    {
        private readonly IChampionshipDbContext _dbContext;

        public DeleteChampionshipCommandHandler(IChampionshipDbContext dbContext) => _dbContext = dbContext;

        public async Task<Unit> Handle(DeleteChampionshipCommand request, CancellationToken token)
        {
            var entity = await _dbContext.Championships.FindAsync(new object[] { request.Id }, token);

            if (entity == null || entity.Id != request.Id)
            {
                throw new NotFoundException(nameof(Championship), request.Id);
            }

            _dbContext.Championships.Remove(entity);
            await _dbContext.SaveChangesAsync(token);

            return Unit.Value;
        }
    }
}
