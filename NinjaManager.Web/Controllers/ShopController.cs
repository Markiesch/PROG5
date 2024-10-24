using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NinjaManager.Data;
using NinjaManager.Data.Services;
using NinjaManager.Web.Models;

namespace NinjaManager.Web.Controllers;

public class ShopController(
    NinjaService ninjaService,
    EquipmentService equipmentService,
    CategoryService categoryService,
    ShopService shopService
) : Controller
{
    [Route("ninjas/{id:int}/shop")]
    public IActionResult Index(int id, [FromQuery] int? selected, string? error = null)
    {
        var ninja = ninjaService.GetNinja(id);
        if (ninja == null) return NotFound("Ninja not found");

        var model = new ShopViewModel
        {
            Ninja = ninja,
            Error = error,
            Items = equipmentService.GetEquipments(selected),
            Categories = categoryService.GetCategories(),
            SelectedCategoryId = selected
        };
        return View(model);
    }

    [HttpPost]
    public IActionResult BuyItem(int id, int ninjaId, int? selected)
    {
        var error = shopService.BuyItem(id, ninjaId);
        if (error != null)
        {
            TempData["error"] = error;
            return RedirectToAction("Index", "Shop", new { id = ninjaId, selected });
        }

        return RedirectToAction("Index", "Ninja", new { id = ninjaId });
    }
}