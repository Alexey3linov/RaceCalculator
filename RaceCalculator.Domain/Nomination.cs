namespace RaceCalculator.Domain
{
    public class Nomination : BaseEntity
    {
        public string              Title   { get; set; } = null!;
        /// <summary>
        /// Список условий, которым должен удовлетворять участник, для зачёта в номинации
        /// </summary>
        public IEnumerable<string> Options { get; set; } = null!;
    }
}
