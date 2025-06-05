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
        partida.moveFoward();
        HttpContext.Session.SetString("partida", Objeto.ObjectToString(partida));
        return View("Habitacion1");
    }
    public IActionResult fromXToY(string answer){

        Partida partida = Objeto.StringToObject<Partida>(HttpContext.Session.GetString("partida"));
        int i = partida.moveFowardForm(answer);
        return View(i);
    }
     public IActionResult fromXToYButton(string answer){
        Partida partida = Objeto.StringToObject<Partida>(HttpContext.Session.GetString("partida"));
        int i = partida.moveFowardButton();
        return View(i);
    }
    public IActionResult IngresarNombre()
    {
        Partida partida = Objeto.StringToObject<Partida>(HttpContext.Session.GetString("partida"));
        ViewBag.name = partida.name;
        return View("IngresarNombre");
    }
    public IActionResult MostrarTutorial()
    {
        return View("Tutorial");
    }
    public IActionResult MostrarIntegrantes()
    {
        return View("Integrantes");
    }
}