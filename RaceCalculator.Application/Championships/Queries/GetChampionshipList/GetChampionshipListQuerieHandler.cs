using AutoMapper;
using AutoMapper.QueryableExtensions;

using MediatR;

using Microsoft.EntityFrameworkCore;

using RaceCalculator.Application.Interfaces;

namespace RaceCalculator.Application.Championships.Queries.GetChampionshipList
{
    public class GetChampionshipListQuerieHandler : IRequestHandler<GetChampionshipListQuerie, ChampionshipListVm>
    {
        private readonly IChampionshipDbContext _dbContext;
        private readonly IMapper _mapper;

        public GetChampionshipListQuerieHandler(IChampionshipDbContext context, IMapper mapper)
            => (_dbContext, _mapper) = (context, mapper);


        public async Task<ChampionshipListVm> Handle(GetChampionshipListQuerie request, CancellationToken token)
        {
            var championshipQuery = await _dbContext.Championships.Where(champ => champ.Id == request.Id)
                .ProjectTo<ChampionshipLookupDto>(_mapper.ConfigurationProvider)
                .ToListAsync();

            return new ChampionshipListVm { Championships = championshipQuery };
        }
    }
}
