using NinjaManager.Data;

namespace NinjaManager.Web.Models;

public class NinjaViewModel
{
    public NinjaViewModel(Ninja ninja, List<Category> categories)
    {
        Ninja = ninja;
        Categories = categories;
        Inventory = new List<Equipment>();
    }
    
    public Ninja Ninja { get; set; }
    public List<Category> Categories { get; set; }
    
    // Inventory: List of Equipment
    public virtual ICollection<Equipment> Inventory { get; set; }

    // Calculated stats
    public int TotalStrength => Inventory?.Sum(e => e.Strength) ?? 0;
    public int TotalIntelligence => Inventory?.Sum(e => e.Intelligence) ?? 0;
    public int TotalAgility => Inventory?.Sum(e => e.Agility) ?? 0;
}