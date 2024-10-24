using NinjaManager.Data.Models;

namespace NinjaManager.Web.Models;

public class ShopViewModel
{
    public Ninja Ninja { get; init; }
    public string? Error { get; init; }
    public List<Equipment> Items { get; init; }
    public List<Category> Categories { get; init; }
    
    public int? SelectedCategoryId { get; init; }
    
    public bool HasItem(int id)
    {
        return Ninja.NinjaEquipments.Any(i => i.EquipmentId == id);
    }
}