using System.Collections.Generic;

namespace NinjaManager.Data;

public class Ninja
{
    public int Id { get; set; } 
    public string Name { get; set; }
    public int Currency { get; set; }
    public List<Equipment> Equipments { get; set; }
}