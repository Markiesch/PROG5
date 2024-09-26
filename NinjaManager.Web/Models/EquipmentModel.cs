public class EquipmentModel
{
    public int EquipmentId { get; set; }
    public string Name { get; set; }
    public decimal ValueInGold { get; set; }
    public int Strength { get; set; }
    public int Intelligence { get; set; }
    public int Agility { get; set; }

    // Equipment category: Head, Chest, Hand, Feet, Ring, Necklace
    public EquipmentCategory Category { get; set; }

    // Relationship with Ninja (Many-to-Many)
    public virtual ICollection<NinjaModel> Ninjas { get; set; }

    public EquipmentModel()
    {
        Ninjas = new List<NinjaModel>();
    }
}

public enum EquipmentCategory
{
    Head,
    Chest,
    Hand,
    Feet,
    Ring,
    Necklace
}

