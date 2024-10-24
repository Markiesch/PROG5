namespace NinjaManager.Data.Models;

public class Ninja
{
    public int Id { get; set; } 
    public string Name { get; set; }
    public int Currency { get; set; }
    public List<NinjaEquipment> NinjaEquipments { get; set; }
    
    public int GearValue => NinjaEquipments.Sum(e => e.BuyPrice);
    public int TotalStrength => NinjaEquipments.Sum(e => e.Equipment.Strength);
    public int TotalIntelligence => NinjaEquipments.Sum(e => e.Equipment.Intelligence);
    public int TotalAgility => NinjaEquipments.Sum(e => e.Equipment.Agility);
}