using Microsoft.EntityFrameworkCore;
using NinjaManager.Data.Models;

namespace NinjaManager.Data.Services;

public class EquipmentService(MainContext context)
{
    public List<Equipment> GetEquipments()
    {
        return context.Equipments
            .Include(x => x.Category)
            .ToList();
    }

    public List<Equipment> GetEquipments(int? categoryId)
    {
        return context.Equipments
            .Include(x => x.Category)
            .Where(x => categoryId == null || x.CategoryId == categoryId)
            .ToList();
    }

    public Equipment? GetEquipment(int id)
    {
        return context.Equipments
            .Include(x => x.Category)
            .Include(x => x.NinjaEquipments)
            .FirstOrDefault(x => x.Id == id);
    }

    public bool CreateEquipment(Equipment equipment)
    {
        context.Equipments.Add(equipment);
        return context.SaveChanges() > 0;
    }

    public bool UpdateEquipment(Equipment equipment)
    {
        context.Equipments.Update(equipment);
        return context.SaveChanges() > 0;
    }

    public bool DeleteEquipment(int id)
    {
        var equipment = context.Equipments
            .Include(x => x.NinjaEquipments)
            .ThenInclude(ninjaEquipment => ninjaEquipment.Ninja)
            .FirstOrDefault(x => x.Id == id);

        if (equipment == null) return false;

        foreach (var ninjaEquipment in equipment.NinjaEquipments.ToList())
        {
            ninjaEquipment.Ninja.Currency += ninjaEquipment.BuyPrice;
            equipment.NinjaEquipments.Remove(ninjaEquipment);
        }

        context.Equipments.Remove(equipment);
        return context.SaveChanges() > 0;
    }
}