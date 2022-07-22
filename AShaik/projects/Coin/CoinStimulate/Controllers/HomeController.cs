using CoinStimulates.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;


namespace CoinStimulates.Controllers
{
    public class HomeController : Controller
    {

       
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }


        coin coin = new coin();
        public IActionResult Index()

        {
            coin.flip();
            ViewBag.a = coin.Up;
            ViewBag.b = coin.Down;   
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
}