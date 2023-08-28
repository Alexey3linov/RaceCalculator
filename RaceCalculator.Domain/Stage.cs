namespace RaceCalculator.Domain
{
    public class Stage : BaseEntity
    {
        public string                  Title          { get; set; } = null!;
        public IEnumerable<Nomination> NominationList { get; set; } = null!;
    }
}
