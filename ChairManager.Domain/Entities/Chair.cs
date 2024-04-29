using System.Runtime.Intrinsics.Arm;
using ChairManager.Domain.Validation;

namespace ChairManager.Domain.Entities;

public sealed class Chair : Entity
{
    public Chair(int chairNumber, string manufacturer)
    {
        ValidateDomain(chairNumber, manufacturer);
    }
    public Chair(int chairNumber, string manufacturer, string? description)
    {
        ValidateDomain(chairNumber, manufacturer);
        Description = description;
    }

    public string Title { get; set; } = string.Empty;
    public int ChairNumber { get; set; }
    public string? Description { get; set; }
    public string Manufacturer { get; set; }
    public bool IsAvailable { get; set; } = false;

    private void ValidateDomain(int chairNumber,  string manufacturer)
    {
        DomainExceptionValidation.When(chairNumber is 0, "Invalid chair number");
        DomainExceptionValidation.When(manufacturer.Length < 3, "Invalid manufacturer, manufacturer is too short and require the minimum of 3 characters");

        ChairNumber = chairNumber;
        Manufacturer = manufacturer;
    }
}