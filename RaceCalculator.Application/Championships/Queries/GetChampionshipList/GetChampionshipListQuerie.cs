using MediatR;

namespace RaceCalculator.Application.Championships.Queries.GetChampionshipList
{
    public class GetChampionshipListQuerie : IRequest<ChampionshipListVm>
    {
        public Guid Id { get; set; }
    }
}
