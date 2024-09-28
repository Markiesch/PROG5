using NinjaManager.Data;

namespace NinjaManager.Web.Models;

public class ShopViewModel
{
    public ShopViewModel(int id, List<Equipment> items)
    {
        Id = id;
        Items = items;
    }
    
    public int Id { get; set; }
    public List<Equipment> Items { get; set; }
}