namespace RaceCalculator.Domain
{
    public class Championship : BaseEntity
    {
        public string                  Title { get; set; } = null!;
        /// <summary>
        /// Дата проведения
        /// </summary>
        public DateTime                StartDate      { get; set; }
        
        public IEnumerable<Stage>      StageList      { get; set; } = null!;
        public IEnumerable<Nomination> NominationList { get; set; } = null!;
        public IEnumerable<Competitor> CompetitorList { get; set; } = null!;


        public int StageCount { get => StageList.Count(); }
    }
}
