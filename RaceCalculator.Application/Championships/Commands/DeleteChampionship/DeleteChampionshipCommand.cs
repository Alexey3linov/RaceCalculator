using MediatR;

namespace RaceCalculator.Application.Championships.Commands.DeleteChampionship
{
    public class DeleteChampionshipCommand : IRequest<Guid>
    {
        public Guid Id { get; set; }
    }
}
