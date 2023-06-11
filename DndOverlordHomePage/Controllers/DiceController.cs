using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using DndOverlordHomePage.Models;

namespace DndOverlordHomePage.Controllers;

public class DiceController : Controller
{
    private readonly ILogger<DiceController> _logger;

    public DiceController(ILogger<DiceController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}