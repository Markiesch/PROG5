using Microsoft.AspNetCore.Mvc;

namespace NinjaManager.Controllers;

public class NinjaController : Controller
{
    private readonly ILogger<NinjaController> _logger;

    public NinjaController(ILogger<NinjaController> logger)
    {
        _logger = logger;
    }
    
    public IActionResult Index()
    {
        return View();
    }
}