using Microsoft.EntityFrameworkCore;
using NinjaManager.Data.Models;

namespace NinjaManager.Data.Services;

public class ShopService(MainContext context)
{
    public string? BuyItem(int id, int ninjaId)
    {
        var ninja = context.Ninjas
            .Include(n => n.NinjaEquipments)
            .ThenInclude(e => e.Equipment)
            .ThenInclude(e => e.Category)
            .FirstOrDefault(n => n.Id == ninjaId);

        if (ninja == null) return "Ninja not found";

        var item = context.Equipments
            .Include(e => e.Category)
            .FirstOrDefault(e => e.Id == id);

        if (item == null) return "Item not found";
        if (ninja.Currency < item.Price) return "Not enough currency";

        var hasItemInCategory = ninja.NinjaEquipments.Any(e => e.Equipment.Category.Id == item.Category.Id);
        if (hasItemInCategory) return "Ninja already has item with same category";

        ninja.Currency -= item.Price;
        ninja.NinjaEquipments.Add(
            new NinjaEquipment
            {
                NinjaId = ninja.Id,
                EquipmentId = item.Id,
                BuyPrice = item.Price
            }
        );
        context.SaveChanges();

        return null;
    }
}