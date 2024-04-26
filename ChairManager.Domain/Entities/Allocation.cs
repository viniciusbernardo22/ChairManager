namespace ChairManager.Domain.Entities;

public class Allocation : Entity
{
    public string Description { get; set; } = string.Empty;
    public DateTime StartingTime { get; set; }
    public DateTime FinishingTime { get; set; }
}