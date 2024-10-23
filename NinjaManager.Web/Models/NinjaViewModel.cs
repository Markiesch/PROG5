using NinjaManager.Data.Models;

namespace NinjaManager.Web.Models;

public class NinjaViewModel
{
    public Ninja Ninja { get; init; }
    public List<Category> Categories { get; init; }

    public List<NinjaEquipment> Inventory => Categories
        .Select(x => new NinjaEquipment(x, Ninja.NinjaEquipments.FirstOrDefault(e => e.Equipment.CategoryId == x.Id)?.Equipment))
        .ToList();

    public int TotalStrength => Inventory.Sum(e => e.Equipment?.Strength ?? 0);
    public int TotalIntelligence => Inventory.Sum(e => e.Equipment?.Intelligence ?? 0);
    public int TotalAgility => Inventory.Sum(e => e.Equipment?.Agility ?? 0);
}

public class NinjaEquipment(Category category, Equipment? equipment)
{
    public Category Category { get; } = category;
    public Equipment? Equipment { get; } = equipment;
}
