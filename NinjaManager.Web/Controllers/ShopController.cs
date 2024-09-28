using Microsoft.AspNetCore.Mvc;
using NinjaManager.Data;

namespace NinjaManager.Web.Controllers;

public class ShopController : Controller
{
    private readonly ILogger<ShopController> _logger;

    public ShopController(ILogger<ShopController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        using var context = new MainContext();
        var items = context.Equipments.ToList();
        return View(items);
    }
}