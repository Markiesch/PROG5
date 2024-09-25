public class Equipment
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
    public virtual ICollection<Ninja> Ninjas { get; set; }

    public Equipment()
    {
        Ninjas = new List<Ninja>();
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

