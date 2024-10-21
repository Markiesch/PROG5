using Microsoft.AspNetCore.Mvc;
using NinjaManager.Data.Services;
using NinjaManager.Web.Models;

namespace NinjaManager.Web.Controllers;

public class NinjaController(CategoryService categoryService, NinjaService ninjaService) : Controller
{
    [HttpGet]
    [Route("ninjas/{id:int}")]
    public IActionResult Index(int id)
    {
        var ninja = ninjaService.GetNinja(id);
        if (ninja == null) return NotFound("Ninja not found");

        var model = new NinjaViewModel(ninja, categoryService.GetCategories());
        return View(model);
    }

    [HttpPost]
    public IActionResult CreateNinja(string name)
    {
        var result = ninjaService.CreateNinja(name);
        if (result == null) return BadRequest("Failed to create ninja");

        return RedirectToAction("Index", new { id = result.Id });
    }

    [HttpGet]
    public IActionResult Delete(int id)
    {
        var success = ninjaService.DeleteNinja(id);
        if (!success) return BadRequest("Failed to delete ninja");

        return RedirectToAction("Index", "Home");
    }

    [HttpGet]
    public IActionResult Reset(int id)
    {
        var success = ninjaService.ResetNinja(id);
        if (!success) return BadRequest("Failed to reset ninja");

        return RedirectToAction("Index", "Home");
    }

    [HttpPost]
    public IActionResult SellEquipment(int id, int equipmentId)
    {
        var success = ninjaService.SellEquipment(id, equipmentId);
        if (!success) return BadRequest("Failed to sell equipment");

        return RedirectToAction("Index", new { id });
    }
}