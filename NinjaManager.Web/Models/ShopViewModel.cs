using NinjaManager.Data;

namespace NinjaManager.Web.Models;

public class ShopViewModel
{
    public ShopViewModel(int id, List<Equipment> items, List<Category> categories, List<int> selectedCategoryIds)
    {
        Id = id;
        Items = items;
        Categories = categories;
        SelectedCategoryIds = selectedCategoryIds;
    }

    public int Id { get; set; }
    public List<Equipment> Items { get; set; }
    public List<Category> Categories { get; set; }
    
    public List<int> SelectedCategoryIds { get; set; }
}