namespace NinjaManager.Data;

public class Category
{
    public int Id { get; set; }
    public string Name { get; set; }
    public List<Equipment> Equipments { get; set; }
}
