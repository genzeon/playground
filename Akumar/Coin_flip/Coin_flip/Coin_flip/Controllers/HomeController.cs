using Coin_flip.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Coin_flip.Controllers
{
   
    public class HomeController : Controller
    {
       // private readonly ILogger<HomeController> _logger;
        public readonly Data context;
        private readonly Coin coin = new Coin();
        public HomeController(Data _context)
        {
            context = _context;
        }

        //public HomeController(ILogger<HomeController> logger)
        //{
        //    _logger = logger;
        //}
        
        
        public IActionResult Index()
        {
            coin.set_Intial_Stage();
            ViewBag.Up = coin.Up;
            ViewBag.Down = coin.Down;    
            return View(coin);
        }
        [HttpPost]
        public IActionResult Index(CoinDataBase c)
        {
            coin.flip();
            context.Add(c);
            context.SaveChanges();
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