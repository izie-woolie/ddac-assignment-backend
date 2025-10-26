namespace DDACAssignment.Models
{
    public class Round
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Order { get; set; } = null!;
        public string Name { get; set; } = null!;
    }
}
