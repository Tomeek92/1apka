using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using PierwszaApka.Models;

namespace PierwszaApka.Controllers;

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


    public IActionResult About()
    {
        var model = new About
        {
            Tittle = "Nazwa czego b�de si� uczy� itd oraz ilo�� czasu po�wi�cania na to",
            JakasLiczba = 2,
            
            Tags = new List<string>() { "Zagadnie 1", "Zagadanienie 2", "Zagadnienie 3", }

        };





        return View(model);
    }

    public IActionResult Privacy()
    {

        var lista = new List<PoCoTaApka>()
      {
          new PoCoTaApka()
          {
              JakasZmiennaString = "4.Celem Apki jest nauka podstaw programowania",
              JakasZmienna = $"1. Nauka Asp.Net.Core 2. Rozwijanie umiej�tno�ci programistycznych 3. Powt�rka ze studi�w"
             
             

          }
      }; //w Controlerze przekazuje model naszego widoku

      

        return View(lista);


        
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
