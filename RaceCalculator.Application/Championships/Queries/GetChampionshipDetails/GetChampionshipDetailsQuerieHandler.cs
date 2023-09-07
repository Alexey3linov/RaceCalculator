using AutoMapper;

using MediatR;

using Microsoft.EntityFrameworkCore;

using RaceCalculator.Application.Common.Exceptions;
using RaceCalculator.Application.Interfaces;
using RaceCalculator.Domain;

namespace RaceCalculator.Application.Championships.Queries.GetChampionshipDetails
{
    public class GetChampionshipDetailsQuerieHandler : IRequestHandler<GetChampionshipDetailsQuerie, ChampionshipDetailsVm>
    {
        private readonly IChampionshipDbContext _dbContext;
        private readonly IMapper _mapper;

        public GetChampionshipDetailsQuerieHandler(IChampionshipDbContext context, IMapper mapper) 
            => (_dbContext, _mapper) = (context, mapper);

        public async Task<ChampionshipDetailsVm> Handle(GetChampionshipDetailsQuerie request, CancellationToken token)
        {
            var entity = _dbContext.Championships.FirstOrDefaultAsync(champ => champ.Id == request.Id);
            
            if (entity == null)
            {
                throw new NotFoundException(nameof(Championship), request.Id);
            }

            return _mapper.Map<ChampionshipDetailsVm>(entity);
        }
    }
}
