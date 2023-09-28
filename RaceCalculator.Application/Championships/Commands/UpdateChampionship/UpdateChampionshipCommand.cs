using MediatR;

using RaceCalculator.Domain;

namespace RaceCalculator.Application.Championships.Commands.UpdateChampionship
{
    public class UpdateChampionshipCommand : BaseChampionshipCommand
    {
        public string                  Title          { get; set; }
        public DateTime                StartDate      { get; set; }
        public IEnumerable<Stage>      StageList      { get; set; }
        public IEnumerable<Nomination> NominationList { get; set; }
        public IEnumerable<Competitor> CompetitorList { get; set; }
    }
}
