namespace DDACAssignment.Models
{
    public class Schedule
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public DateTime? StartTime { get; set; }
        public DateTime? EndTime { get; set; }
        public string Venue { get; set; } = null!;
    }
}
