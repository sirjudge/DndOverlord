using System.Diagnostics;
using DndOverlordHomePage.Models;
using DndOverlordHomePage.Repositories;
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
        var characterRepository = new CharacterRepository();
        var characterList = characterRepository.GetCharacterList();
        return View("ViewCharacterList");
    }
    
    public IActionResult View(){
        var characterRepository = new CharacterRepository();

        //TODO: take in character ID
        var characterID = 1;
        var characterList = characterRepository.Get(characterID);
        return View("ViewCharacter");
    }
    
    public IActionResult Edit(){
        return View("NewUpdateCharacter");
    }
    
    public IActionResult New(){
        return View("NewUpdateCharacter");
    }
    
    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}