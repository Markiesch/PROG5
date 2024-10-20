using Microsoft.EntityFrameworkCore;

namespace NinjaManager.Data.Services;

public class NinjaService(MainContext context)
{
    public List<Ninja> GetNinjas()
    {
        return context.Ninjas
            .Include(n => n.Equipments)
            .ToList();
    }
    
    public Ninja? GetNinja(int id)
    {
        return context.Ninjas
            .Include(n => n.Equipments)
            .FirstOrDefault(n => n.Id == id);
    }
    
    public Ninja? CreateNinja(Ninja ninja)
    {
        var res = context.Ninjas.Add(ninja);
        var success = context.SaveChanges() > 0;
        
        return success ? res.Entity : null;
    }
    
    public bool DeleteNinja(int id)
    {
        var ninja = context.Ninjas.FirstOrDefault(n => n.Id == id);
        if (ninja == null)
        {
            return false;
        }
        
        context.Ninjas.Remove(ninja);
        return context.SaveChanges() > 0;
    }
    
    public bool ResetNinja(int id)
    {
        var ninja = context.Ninjas.Include(n => n.Equipments).FirstOrDefault(n => n.Id == id);
        if (ninja == null)
        {
            return false;
        }
        
        ninja.Currency += ninja.GearValue;
        ninja.Equipments.Clear();
        return context.SaveChanges() > 0;
    }
}