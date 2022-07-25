using CoinFlipWeb.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Coins;
namespace CoinFlipWeb.Controllers
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
            coin.Flip();
            ViewBag.up = coin.Up;
            ViewBag.down = coin.Down;
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