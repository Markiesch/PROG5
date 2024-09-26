using Microsoft.AspNetCore.Mvc;
using NinjaManager.Data;

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

        var ninja = context.Ninjas.Find(id);

        if (ninja == null)
        {
            return NotFound("Ninja not found");
        }
        
        return View(ninja);
    }
}