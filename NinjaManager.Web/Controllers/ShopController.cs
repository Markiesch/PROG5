using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NinjaManager.Data;
using NinjaManager.Web.Models;

namespace NinjaManager.Web.Controllers;

public class ShopController : Controller
{
    [Route("ninjas/{id}/shop")]
    public IActionResult Index(int id, [FromQuery] string? selected)
    {
        using var context = new MainContext();
        var items = context.Equipments.ToList();
        var categories = context.Categories.ToList();

        List<int> selectedCategoryIds = selected?.Split(',').Select(int.Parse).ToList() ?? new List<int>();

        if (selectedCategoryIds.Any())
        {
            items = items.Where(item => selectedCategoryIds.Contains(item.Category.Id)).ToList();
        }

        var model = new ShopViewModel(id, items, categories, selectedCategoryIds);

        return View(model);
    }

    [HttpPost]
    public IActionResult BuyItem(int id, int ninjaId)
    {
        using var context = new MainContext();

        var ninja = context.Ninjas
            .Include(n => n.Equipments)
            .ThenInclude(e => e.Category)
            .FirstOrDefault(n => n.Id == ninjaId);

        if (ninja == null) return NotFound("Ninja not found");

        var item = context.Equipments
            .Include(e => e.Category)
            .FirstOrDefault(e => e.Id == id);

        if (item == null) return NotFound("Item not found");
        if (ninja.Currency < item.Price) return BadRequest("Not enough currency");

        var hasItemInCategory = ninja.Equipments.Any(e => e.Category.Id == item.Category.Id);
        if (hasItemInCategory) return BadRequest("Ninja already has item with same category");

        ninja.Currency -= item.Price;
        ninja.Equipments.Add(item);
        context.SaveChanges();

        return RedirectToAction("Index", new { id = ninjaId });
    }
}