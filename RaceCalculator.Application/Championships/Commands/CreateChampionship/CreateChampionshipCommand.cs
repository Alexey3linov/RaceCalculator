using MediatR;

using RaceCalculator.Domain;

namespace RaceCalculator.Application.Championships.Commands.CreateChampionship
{
    public class CreateChampionshipCommand : IRequest<Guid>
    {
        public string                  Title          { get; set; }
        public DateTime                StartDate      { get; set; }
        public IEnumerable<Stage>      StageList      { get; set; }
        public IEnumerable<Nomination> NominationList { get; set; }
        public IEnumerable<Competitor> CompetitorList { get; set; }
    }
}
