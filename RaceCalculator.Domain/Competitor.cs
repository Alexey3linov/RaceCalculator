namespace RaceCalculator.Domain
{
    public class Competitor : BaseEntity
    {
        public string            Name             { get; set; } = null!;
        public RiderClass        Class            { get; set; }
        /// <summary>
        /// Id чемпионатов, в которых принял участие
        /// </summary>
        public IEnumerable<Guid> ChampionshipList { get; set; } = null!;
    }
}
