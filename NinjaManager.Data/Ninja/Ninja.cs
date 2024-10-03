namespace NinjaManager.Data;

public class Ninja
{
    public int Id { get; set; } 
    public string Name { get; set; }
    public int Currency { get; set; }
    public List<Equipment> Equipments { get; set; }
    
    public int GearValue => Equipments.Sum(e => e.Price);
    
    public int TotalStrength => Equipments.Sum(e => e.Strength);
    public int TotalIntelligence => Equipments.Sum(e => e.Intelligence);
    public int TotalAgility => Equipments.Sum(e => e.Agility);
}