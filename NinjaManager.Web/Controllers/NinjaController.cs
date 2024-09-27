using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NinjaManager.Data;
using NinjaManager.Web.Models;

namespace NinjaManager.Controllers;

public class NinjaController : Controller
{
    private readonly ILogger<NinjaController> _logger;

    public NinjaController(ILogger<NinjaController> logger)
    {
        _logger = logger;
    }

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
}