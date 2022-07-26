using COIN_FLipping.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Flpping;


namespace COIN_FLipping.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        Coin c = new Coin();
        public IActionResult Index()
        {
            c.flip();
            ViewBag.SideUp = c.Up;
            ViewBag.SideDown = c.Down;

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