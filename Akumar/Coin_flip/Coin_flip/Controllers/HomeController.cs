using Coin_flip.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Coin_flip.Controllers
{
    public enum Face
    {
        Heads, tails
    }
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        
        Coin con = new Coin();
        public IActionResult Index(Coin coin)
        {
            con.flip();
            ViewBag.Up = con.Up;
            ViewBag.Down = con.Down;    
            return View(coin);
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
}