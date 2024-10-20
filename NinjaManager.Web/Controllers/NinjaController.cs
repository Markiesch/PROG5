using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NinjaManager.Data;
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

        if (ninja == null)
        {
            return NotFound("Ninja not found");
        }

        var model = new NinjaViewModel(ninja, categoryService.GetCategories());
        return View(model);
    }

    [HttpPost]
    public IActionResult CreateNinja(string name)
    {
        var result = ninjaService.CreateNinja(new Ninja
        {
            Name = name,
            Currency = 999
        });

        if (result == null)
        {
            return BadRequest("Failed to create ninja");
        }

        return RedirectToAction("Index", new { id = result.Id });
    }

    [HttpPost]
    public IActionResult Delete(int id)
    {
        var success = ninjaService.DeleteNinja(id);
        if (!success) return BadRequest("Failed to delete ninja");

        return RedirectToAction("Index", "Home");
    }

    public IActionResult Reset(int id)
    {
        using var context = new MainContext();

        var ninja = context.Ninjas.Include(n => n.Equipments).FirstOrDefault(n => n.Id == id);
        if (ninja == null)
        {
            return NotFound();
        }

        ninja.Currency += ninja.GearValue;
        ninja.Equipments.Clear();
        context.SaveChanges();

        return RedirectToAction("Index", "Home");
    }

    [HttpPost]
    public IActionResult SellEquipment(int id, int equipmentId)
    {
        using var context = new MainContext();
        var ninja = context.Ninjas
            .Include(n => n.Equipments)
            .FirstOrDefault(n => n.Id == id);

        if (ninja == null)
        {
            return NotFound();
        }

        var equipment = ninja.Equipments.FirstOrDefault(e => e.Id == equipmentId);

        if (equipment == null)
        {
            return NotFound();
        }

        ninja.Currency += equipment.Price;
        ninja.Equipments.Remove(equipment);
        context.SaveChanges();

        return RedirectToAction("Index", new { id });
    }
}