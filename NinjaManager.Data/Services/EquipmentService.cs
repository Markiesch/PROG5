using Microsoft.EntityFrameworkCore;

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
            .Include(x => x.Ninjas)
            .FirstOrDefault(x => x.Id == id);
    }

    public bool CreateEquipment(Equipment equipment)
    {
        context.Equipments.Add(equipment);
        return context.SaveChanges() > 0;
    }

    public bool UpdateEquipment(Equipment equipment)
    {
        Console.WriteLine(equipment.Id);

        context.Equipments.Update(equipment);
        return context.SaveChanges() > 0;
    }

    public bool DeleteEquipment(int id)
    {
        var equipment = context.Equipments
            .Include(x => x.Ninjas)
            .FirstOrDefault(x => x.Id == id);

        if (equipment == null)
        {
            return false;
        }

        foreach (var ninja in equipment.Ninjas)
        {
            ninja.Equipments.Remove(equipment);
        }

        context.Equipments.Remove(equipment);
        return context.SaveChanges() > 0;
    }
}