using MediatR;
using RaceCalculator.Domain;

namespace RaceCalculator.Application.Championships.Queries.GetChampionshipDetails
{
    public class GetChampionshipDetailsQuerie : IRequest<ChampionshipDetailsVm>
    {
        public Guid Id { get; set; }
    }
}
