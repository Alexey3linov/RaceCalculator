namespace RaceCalculator.Domain
{
    public class Championship
    {
        public Guid                    Id             { get; set; }
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





    public class Stage
    {
        public Guid                    Id             { get; set; }
        public string                  Title          { get; set; }
        public IEnumerable<Nomination> NominationList { get; set; }
    }

    public class Nomination
    {
        public Guid                Id      { get; set; }
        public string              Title   { get; set; }
        /// <summary>
        /// Список условий, которым должен удовлетворять участник, для зачёта в номинации
        /// </summary>
        public IEnumerable<string> Options { get; set; }
    }

    public class Competitor
    {
        public Guid              Id               { get; set; }
        public string            Name             { get; set; }
        public RiderClass        Class            { get; set; }
        /// <summary>
        /// Id чемпионатов, в которых принял участие
        /// </summary>
        public IEnumerable<Guid> ChampionshipList { get; set; }
    }

    public enum RiderClass
    {
        A,
        B,
        C1,
        C2,
        C3,
        D1,
        D2,
        D3,
        D4,
        N
    }
}
