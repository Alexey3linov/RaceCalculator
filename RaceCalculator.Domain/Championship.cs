namespace RaceCalculator.Domain
{
    public class Championship : BaseEntity
    {
        public string                  Title          { get; set; }
        /// <summary>
        /// Дата проведения
        /// </summary>
        public DateTime                StartDate      { get; set; }
        
        public IEnumerable<Stage>      StageList      { get; set; }
        public IEnumerable<Nomination> NominationList { get; set; }
        public IEnumerable<Competitor> CompetitorList { get; set; }


        public int StageCount { get => StageList.Count(); }
    }
}
