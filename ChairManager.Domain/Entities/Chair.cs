namespace ChairManager.Domain.Entities;

public sealed class Chair : Entity
{
    public Chair(int chairNumber, string? description, string manufacturer, bool isAvailable)
    {
        ValidateDomain(chairNumber, description, manufacturer, isAvailable);
    }

    public string Title { get; set; } = string.Empty;
    public int ChairNumber { get; set; }
    public string? Description { get; set; }
    public string Manufacturer { get; set; }
    public bool IsAvailable { get; set; } = false;

    private void ValidateDomain(int chairNumber, string? description, string manufacturer, bool isAvailable)
    {
        
        ChairNumber = chairNumber;
        Description = description;
        Manufacturer = manufacturer;
        IsAvailable = isAvailable;
    }
}