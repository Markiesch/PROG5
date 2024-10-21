using NinjaManager.Data;
using NinjaManager.Data.Models;

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
    
    public List<NinjaEquipment> Inventory {
        get
        {
            var inventory = new List<NinjaEquipment>();
            foreach (var category in Categories)
            {
                var equipment = Ninja.Equipments.FirstOrDefault(e => e.CategoryId == category.Id);
                inventory.Add(new NinjaEquipment(category, equipment));
            }
            return inventory;
        } 
    }

    public int TotalStrength => Inventory.Sum(e => e.Equipment?.Strength ?? 0);
    public int TotalIntelligence => Inventory.Sum(e => e.Equipment?.Intelligence ?? 0);
    public int TotalAgility => Inventory.Sum(e => e.Equipment?.Agility ?? 0);
}

public class NinjaEquipment
{
    public NinjaEquipment(Category category, Equipment? equipment)
    {
        Category = category;
        Equipment = equipment;
    }
    
    public Category Category { get; set; }
    public Equipment? Equipment { get; set; }
}
