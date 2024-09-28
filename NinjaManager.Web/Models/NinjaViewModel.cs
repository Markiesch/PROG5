using NinjaManager.Data;

namespace NinjaManager.Web.Models;

public class NinjaViewModel
{
    public NinjaViewModel(Ninja ninja, List<Category> categories)
    {
        Ninja = ninja;
        Categories = categories;
    }
    
    public Ninja Ninja { get; set; }
    public List<Category> Categories { get; set; }
    
    public List<Equipment?> Inventory {
        get
        {
            return Categories.Select(item => Ninja.Equipments
                .Find(e => e.Id == item.Id)).ToList();
        } 
    }

    public int TotalStrength => Inventory.Sum(e => e?.Strength ?? 0);
    public int TotalIntelligence => Inventory.Sum(e => e?.Intelligence ?? 0);
    public int TotalAgility => Inventory.Sum(e => e?.Agility ?? 0);
}