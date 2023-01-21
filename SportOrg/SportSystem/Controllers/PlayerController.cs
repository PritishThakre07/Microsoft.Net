using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using SportSystem.Models;
using BOL;
using BLL;

namespace SportSystem.Controllers;

public class PlayerController : Controller
{
    private readonly ILogger<PlayerController> _logger;

    public PlayerController(ILogger<PlayerController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        
        return View();
    }

    public IActionResult AllPlayer()
    {
        Middleware all = new Middleware();

        List<Player> allply = new List<Player>();

        allply = all.GetAllPlayer();

        this.ViewData["player"]= allply;
        return View();
        
    }

    public IActionResult Allply()
    {
        Middleware all = new Middleware();

        List<Player> allply = new List<Player>();

        allply= all.GetAllPlayer();

        ViewBag.Players = allply;
        return View();


    }

    public IActionResult DetailsAll()
    {
        Middleware mid = new Middleware();

        List<Player> allply = new List<Player>();

        allply = mid.DetailsAll();
        this.ViewData["ply"]=allply;

        return View();
        
    }

    public IActionResult Insert()
    {
       Player ply = new Player();
       return View(ply);

       
    }

    [HttpPost]
    public IActionResult Insert(Player ply)
    {
        if(!ModelState.IsValid){

            return View();
        }
        Middleware mid = new Middleware();
        
        mid.Insert(ply);

        Console.WriteLine(ply.ToString());
        
        return RedirectToAction("index");
       

       
    }

    public IActionResult GetOne()
    {
        Player ply = new Player();

        return View(ply);
    }

   [HttpPost]
    public IActionResult GetOne(int id)
    {
        Middleware mid = new Middleware();

          Player ply = mid.GetOne(id);
          this.ViewData["ply"]= ply;

        return Json(ply);
    }

    public IActionResult Update()
    {
        Player ply = new Player();
         return View(ply);
    }

    [HttpPost]
    public IActionResult Update(Player ply)
    {
       Middleware mid = new Middleware();
       bool status=mid.Upadte(ply);
       Console.WriteLine(status);
       return RedirectToAction("Index");
    }


    public IActionResult Auth()
    {
        
        
        return View();
    }
    
    [HttpPost]
    public IActionResult Auth(int Id ,string name)
    {
       Middleware mid = new Middleware();
         List<Player> ply = mid.Details();

        
        
        foreach (Player all in ply)
        {
            if(all.Id == Id && all.Name == name)
            {
                return RedirectToAction("Index");
            }
        }
        return View();
    }

    
    
}
