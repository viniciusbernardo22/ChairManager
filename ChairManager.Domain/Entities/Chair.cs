namespace ChairManager.Domain.Entities;

public class Chair : Entity
{
    public string Title { get; set; } = string.Empty;
    public int ChairNumber { get; set; }
    public string Description { get; set; }
    public string Manufacturer { get; set; }
}