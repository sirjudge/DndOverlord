using System.Diagnostics;
using DndOverlordHomePage.Models;
using Microsoft.AspNetCore.Mvc;

namespace DndOverlordHomePage.Controllers;

public class CharacterController : Controller
{
    private readonly ILogger<CharacterController> _logger;

    public CharacterController(ILogger<CharacterController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View("ViewCharacterList");
    }
    
    public IActionResult View(){
        return View("ViewCharacter");
    }
    
        public IActionResult Edit(){
            return View("ViewCharacter");
        }
    
    
    
    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}