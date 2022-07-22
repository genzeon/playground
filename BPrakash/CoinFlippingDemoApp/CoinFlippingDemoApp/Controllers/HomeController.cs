using CoinFlippingDemoApp.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace CoinFlippingDemoApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

         Coin c=new Coin();
        public IActionResult Index()
        {
            c.SetSides();
            ViewBag.coin = c.ToString();
            return View();
        }

        public IActionResult Privacy()
        {
            c.Flip();
            ViewBag.coin = c.ToString();
            return View("Index");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}