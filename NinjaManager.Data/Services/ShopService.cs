using Microsoft.EntityFrameworkCore;

namespace NinjaManager.Data.Services;

public class ShopService(MainContext context)
{
    public string? BuyItem(int id, int ninjaId)
    {
        var ninja = context.Ninjas
            .Include(n => n.Equipments)
            .ThenInclude(e => e.Category)
            .FirstOrDefault(n => n.Id == ninjaId);

        if (ninja == null) return "Ninja not found";

        var item = context.Equipments
            .Include(e => e.Category)
            .FirstOrDefault(e => e.Id == id);

        if (item == null) return "Item not found";
        if (ninja.Currency < item.Price) return "Not enough currency";

        var hasItemInCategory = ninja.Equipments.Any(e => e.Category.Id == item.Category.Id);
        if (hasItemInCategory) return "Ninja already has item with same category";

        ninja.Currency -= item.Price;
        ninja.Equipments.Add(item);
        context.SaveChanges();

        return null;
    }
    
}