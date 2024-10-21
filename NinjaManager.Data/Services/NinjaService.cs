using Microsoft.EntityFrameworkCore;

namespace NinjaManager.Data.Services;

public class NinjaService(MainContext context)
{
    public List<Ninja> GetNinjas()
    {
        return context.Ninjas.Include(n => n.Equipments).ToList();
    }

    public Ninja? GetNinja(int id)
    {
        return context.Ninjas.Include(n => n.Equipments).FirstOrDefault(n => n.Id == id);
    }

    public Ninja? CreateNinja(string name)
    {
        var ninja = new Ninja { Name = name, Currency = 999 };
        context.Ninjas.Add(ninja);
        return context.SaveChanges() > 0 ? ninja : null;
    }

    public bool DeleteNinja(int id)
    {
        var ninja = context.Ninjas.Find(id);
        if (ninja == null) return false;

        context.Ninjas.Remove(ninja);
        return context.SaveChanges() > 0;
    }

    public bool ResetNinja(int id)
    {
        var ninja = context.Ninjas
            .Include(n => n.Equipments)
            .FirstOrDefault(n => n.Id == id);
        if (ninja == null) return false;

        ninja.Currency += ninja.GearValue;
        ninja.Equipments.Clear();
        return context.SaveChanges() > 0;
    }

    public bool SellEquipment(int id, int equipmentId)
    {
        var ninja = context.Ninjas
            .Include(n => n.Equipments)
            .FirstOrDefault(n => n.Id == id);
        if (ninja == null) return false;

        var equipment = ninja.Equipments.FirstOrDefault(e => e.Id == equipmentId);
        if (equipment == null) return false;

        ninja.Currency += equipment.Price;
        ninja.Equipments.Remove(equipment);
        return context.SaveChanges() > 0;
    }
}