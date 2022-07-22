using FlipCoin.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace FlipCoin.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

            Coin coin = new Coin();
        public IActionResult Index()
        {
            coin.set_intial_value();
            ViewBag.result = coin.ToString();
            coin.Flip();
            ViewBag.result = coin.ToString();
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