namespace RaceCalculator.Domain
{
    public class Stage : BaseEntity
    {
        public string                  Title          { get; set; }
        public IEnumerable<Nomination> NominationList { get; set; }
    }
}
