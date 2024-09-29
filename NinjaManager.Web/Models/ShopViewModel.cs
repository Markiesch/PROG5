using NinjaManager.Data;

namespace NinjaManager.Web.Models;

public class ShopViewModel
{
    public ShopViewModel(Ninja ninja, List<Equipment> items, List<Category> categories, int? selectedCategoryId)
    {
        Ninja = ninja;
        Items = items;
        Categories = categories;
        SelectedCategoryId = selectedCategoryId;
    }

    public Ninja Ninja { get; set; }
    public List<Equipment> Items { get; set; }
    public List<Category> Categories { get; set; }
    
    public int? SelectedCategoryId { get; set; }
}