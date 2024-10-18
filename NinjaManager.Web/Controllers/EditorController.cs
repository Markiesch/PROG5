using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NinjaManager.Data;
using NinjaManager.Web.Models;

namespace NinjaManager.Web.Controllers;

public class EditorController : Controller
{
    [Route("/editor")]
    public IActionResult Index()
    {
        using var context = new MainContext();
        var model = new EditorViewModel()
        {
            Equipments = context.Equipments.Include(x => x.Category).ToList()
        };

        return View(model);
    }
    
    [HttpGet]
    [Route("/editor/equipment/{id}/update")]
    public IActionResult Update(int id)
    {
        using var context = new MainContext();
        var equipment = context.Equipments.Find(id);
        if (equipment == null)
        {
            return NotFound();
        }
        
        var categories = context.Categories.ToList();

        var model = new EditorEquipmentViewModel()
        {
            Equipment = equipment,
            Categories = categories
        };

        return View(model);
    }
    
    [HttpPost]
    [Route("/editor/equipment/{id}/update")]
    public IActionResult Update(int id, EditorEquipmentViewModel model)
    {
        using var context = new MainContext();
        var equipment = context.Equipments.Find(id);
        if (equipment == null)
        {
            return NotFound();
        }

        equipment.Name = model.Equipment.Name;
        equipment.CategoryId = model.Equipment.CategoryId;
        equipment.Rarity = model.Equipment.Rarity;
        equipment.Price = model.Equipment.Price;
        equipment.Strength = model.Equipment.Strength;
        equipment.Agility = model.Equipment.Agility;
        equipment.Intelligence = model.Equipment.Intelligence;

        context.SaveChanges();

        return RedirectToAction("Index");
    }
    
    [HttpGet]
    [Route("/editor/equipment/create")]
    public IActionResult Create()
    {
        using var context = new MainContext();
        var categories = context.Categories.ToList();

        var model = new EditorEquipmentViewModel()
        {
            Equipment = new Equipment(),
            Categories = categories
        };

        return View(model);
    }
    
    [HttpPost]
    [Route("/editor/equipment/create")]
    public IActionResult CreateItem(EditorEquipmentViewModel model)
    {
        using var context = new MainContext();
        context.Equipments.Add(model.Equipment);
        context.SaveChanges();

        return RedirectToAction("Index");
    }

    [HttpGet]
    [Route("/editor/equipment/{id}/delete")]
    public IActionResult Delete(int id)
    {
        using var context = new MainContext();
        var equipment = context.Equipments.Include(e => e.Ninjas).FirstOrDefault(e => e.Id == id);
        if (equipment == null)
        {
            return NotFound();
        }

        var categories = context.Categories.ToList();

        var model = new EditorEquipmentViewModel()
        {
            Equipment = equipment,
            Categories = categories,
        };

        return View(model);
    }

    [HttpPost, ActionName("Delete")]
    [Route("/editor/equipment/{id}/delete")]
    public IActionResult DeleteConfirmed(int id)
    {
        using var context = new MainContext();
        var equipment = context.Equipments.Include(e => e.Ninjas).FirstOrDefault(e => e.Id == id);
        if (equipment == null)
        {
            return NotFound();
        }

        foreach (var ninja in equipment.Ninjas)
        {
            ninja.Equipments.Remove(equipment);
        }

        context.Equipments.Remove(equipment);
        context.SaveChanges();

        return RedirectToAction("Index");
    }
}