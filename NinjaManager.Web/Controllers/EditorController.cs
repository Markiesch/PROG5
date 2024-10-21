using Microsoft.AspNetCore.Mvc;
using NinjaManager.Data;
using NinjaManager.Data.Services;
using NinjaManager.Web.Models;

namespace NinjaManager.Web.Controllers;

public class EditorController(EquipmentService equipmentService, CategoryService categoryService) : Controller
{
    [HttpGet]
    [Route("/editor")]
    public IActionResult Index()
    {
        var model = new EditorViewModel
        {
            Equipments = equipmentService.GetEquipments()
        };

        return View(model);
    }
    
    [HttpGet]
    [Route("/editor/equipment/{id:int}/update")]
    public IActionResult Update(int id)
    {
        var equipment = equipmentService.GetEquipment(id);
        if (equipment == null)
        {
            return NotFound();
        }

        var categories = categoryService.GetCategories();

        var model = new EditorEquipmentViewModel
        {
            Equipment = equipment,
            Categories = categories
        };

        return View(model);
    }
    
    [HttpPost]
    [Route("/editor/equipment/{id:int}/update")]
    public IActionResult Update(int id, EditorEquipmentViewModel model)
    {
        model.Equipment.Id = id;
        
        var success = equipmentService.UpdateEquipment(model.Equipment);

        if (!success)
        {
            return BadRequest();
        }
        
        return RedirectToAction("Index");
    }
    
    [HttpGet]
    [Route("/editor/equipment/create")]
    public IActionResult Create()
    {
        var model = new EditorEquipmentViewModel
        {
            Equipment = new Equipment(),
            Categories = categoryService.GetCategories()
        };

        return View(model);
    }
    
    [HttpPost]
    [Route("/editor/equipment/create")]
    public IActionResult CreateItem(EditorEquipmentViewModel model)
    {
        var success = equipmentService.CreateEquipment(model.Equipment);
        
        if (!success)
        {
            return BadRequest();
        }

        return RedirectToAction("Index");
    }

    [HttpGet]
    [Route("/editor/equipment/{id:int}/delete")]
    public IActionResult Delete(int id)
    {
        var equipment = equipmentService.GetEquipment(id);
        if (equipment == null)
        {
            return NotFound();
        }

        var model = new EditorEquipmentViewModel
        {
            Equipment = equipment,
            Categories = categoryService.GetCategories(),
        };

        return View(model);
    }

    [HttpPost, ActionName("Delete")]
    [Route("/editor/equipment/{id:int}/delete")]
    public IActionResult DeleteConfirmed(int id)
    {
        var success = equipmentService.DeleteEquipment(id);
        
        if (!success)
        {
            return BadRequest();
        }

        return RedirectToAction("Index");
    }
}