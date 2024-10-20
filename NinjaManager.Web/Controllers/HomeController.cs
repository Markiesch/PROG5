using Microsoft.AspNetCore.Mvc;
using NinjaManager.Data.Services;

namespace NinjaManager.Web.Controllers;

public class HomeController(NinjaService ninjaService) : Controller
{
    [HttpGet]
    public IActionResult Index()
    {
        return View(ninjaService.GetNinjas());
    }
}