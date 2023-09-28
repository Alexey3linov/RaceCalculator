using MediatR;

namespace RaceCalculator.Application.Championships.Commands
{
    public class BaseChampionshipCommand : IRequest<Guid>
    {
        public Guid Id { get; set; }
    }
}
