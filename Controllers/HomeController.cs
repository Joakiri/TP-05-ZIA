using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TP_05_ZIA.Models;

namespace TP_05_ZIA.Controllers;
public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }
    
    public IActionResult play (string name){
        Partida partida = new Partida(name);
        partida.moveFowardButton();
        HttpContext.Session.SetString("partida", Objeto.ObjectToString(partida));
        ViewBag.name = name;
        return View("Habitacion1");
    }
    [HttpPost]
    
    public IActionResult fromXToY(string answer){

        Partida partida = Objeto.StringToObject<Partida>(HttpContext.Session.GetString("partida"));
        int i = partida.moveFowardForm(answer);
        return View(i);
    }

     public IActionResult fromXToYButton(){
        Partida partida = Objeto.StringToObject<Partida>(HttpContext.Session.GetString("partida"));
        int i = partida.moveFowardButton();
        return View($"Habitacion{i}");
    }
    public IActionResult ANombre(string name)
    {
        ViewBag.name = name;
        return View("IngresarNombre");
    }
    [HttpPost]
    public IActionResult fromXToPerdiste(){
        return View("Perdiste");
    }
    public IActionResult MostrarIntegrantes()
    {
        return View("Integrantes");
    }
      public IActionResult MostrarTutorial()
    {
        return View("Tutorial");
    }
}
