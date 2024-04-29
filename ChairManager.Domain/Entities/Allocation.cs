namespace ChairManager.Domain.Entities;

public sealed class Allocation
{
    public Allocation(DateTime startingTime, DateTime finishingTime)
    {
        StartingTime = startingTime;
        FinishingTime = finishingTime;
        Description = String.Empty;
    }
    public Allocation(DateTime startingTime, DateTime finishingTime, string? description)
    {
        StartingTime = startingTime;
        FinishingTime = finishingTime;
        Description = description;
    }

    public Guid EventId = Guid.NewGuid();
    public string? Description { get; set; } 
    public DateTime StartingTime { get; set; }
    public DateTime FinishingTime { get; set; }
}