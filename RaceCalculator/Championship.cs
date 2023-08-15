namespace RaceCalculator
{
    public class Championship
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        /// <summary>
        /// Дата проведения
        /// </summary>
        public DateTime StartDate { get; set; }
        
        public IEnumerable<Stage> StageList { get; set; }
        public int StageCount { get => StageList.Count(); }
    }





    public class Stage
    {
        public Guid Id { get; set; }
    }
}
