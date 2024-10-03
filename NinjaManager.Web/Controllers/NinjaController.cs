using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NinjaManager.Data;
using NinjaManager.Web.Models;

namespace NinjaManager.Web.Controllers;

public class NinjaController : Controller
{
    [Route("ninjas/{id}")]
    public IActionResult Index(int id)
    {
        using var context = new MainContext();

        var ninja = context.Ninjas
            .Include(n => n.Equipments)
            .FirstOrDefault(n => n.Id == id);

        if (ninja == null)
        {
            return NotFound("Ninja not found");
        }

        var categories = context.Categories.ToList();

        var model = new NinjaViewModel(ninja, categories);
        return View(model);
    }

    [HttpPost]
    public IActionResult CreateNinja(string Name)
    {
        using var context = new MainContext();

        var newNinja = new Ninja();
        newNinja.Currency = 999;
        newNinja.Name = Name;
        var res = context.Ninjas.Add(newNinja);

        context.SaveChanges();

        return RedirectToAction("Index", new { id = res.Entity.Id });
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