using System.Diagnostics;
using DndOverlordHomePage.Models;
using Microsoft.AspNetCore.Mvc;

namespace DndOverlordHomePage.Controllers;

public class DiceController : Controller
{
    private readonly ILogger<DiceController> _logger;

    public DiceController(ILogger<DiceController> logger)
    {
        _logger = logger;
    }

    public IActionResult DiceRoller()
    {
        return View();
    }
    
    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}