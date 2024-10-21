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
    public IActionResult Index(int id, [FromQuery] int? selected)
    {
        var ninja = ninjaService.GetNinja(id);
        if (ninja == null) return NotFound("Ninja not found");

        var model = new ShopViewModel
        {
            Ninja = ninja,
            Items = equipmentService.GetEquipments(selected),
            Categories = categoryService.GetCategories(),
            SelectedCategoryId = selected
        };
        return View(model);
    }

    [HttpPost]
    public IActionResult BuyItem(int id, int ninjaId)
    {
        var error = shopService.BuyItem(id, ninjaId);
        if (error != null) return BadRequest(error);

        return RedirectToAction("Index", "Ninja", new { id = ninjaId });
    }
}