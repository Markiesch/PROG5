namespace NinjaManager.Data;

public class Equipment
{
    public int Id { get; set; }
    public int Price { get; set; }
    public string Name { get; set; }
    public int Strength { get; set; }
    public int Intelligence { get; set; }
    public int Agility { get; set; }
    public int CategoryId { get; set; }
    public Category Category { get; set; }
    public List<Ninja> Ninjas { get; set; }
}