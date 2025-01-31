﻿namespace NinjaManager.Data.Models;

public class Equipment
{
    public int Id { get; set; }
    public int Price { get; set; }
    public string Name { get; set; }
    public int Strength { get; set; }
    public int Intelligence { get; set; }
    public string Rarity { get; set; }  
    public int Agility { get; set; }
    public int CategoryId { get; set; }
    public Category Category { get; set; }
    public List<NinjaEquipment> NinjaEquipments { get; set; }

    public string Img => Rarity.ToLower() + "_" + Category?.Name.ToLower();
}