using NinjaManager.Data;

namespace NinjaManager.Web.Models;

public class EditorEquipmentViewModel
{
    public Equipment Equipment { get; init; }
    public List<Category> Categories { get; init; }

    public List<string> Rarities { get; init; } =
    [
        "Leather",
        "Iron",
        "Gold",
        "Diamond",
        "Mythic"
    ];
}