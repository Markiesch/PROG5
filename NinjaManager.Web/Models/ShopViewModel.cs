using NinjaManager.Data.Models;

namespace NinjaManager.Web.Models;

public class ShopViewModel
{
    public Ninja Ninja { get; init; }
    public List<Equipment> Items { get; init; }
    public List<Category> Categories { get; init; }
    
    public int? SelectedCategoryId { get; init; }
    
    public bool HasItemInCategory(int categoryId)
    {
        return Ninja.NinjaEquipments.Any(i => i.Equipment.CategoryId == categoryId);
    }
}