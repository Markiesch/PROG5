﻿using System.Collections.Generic;

public class NinjaModel
{
    public int NinjaId { get; set; }
    public string Name { get; set; }
    public decimal Gold { get; set; }
    
    // Inventory: List of Equipment
    public virtual ICollection<EquipmentModel> Inventory { get; set; }

    // Calculated stats
    public int TotalStrength => Inventory?.Sum(e => e.Strength) ?? 0;
    public int TotalIntelligence => Inventory?.Sum(e => e.Intelligence) ?? 0;
    public int TotalAgility => Inventory?.Sum(e => e.Agility) ?? 0;
    public decimal TotalGoldValue => Inventory?.Sum(e => e.ValueInGold) ?? 0;

    public NinjaModel()
    {
        Inventory = new List<EquipmentModel>();
    }
}