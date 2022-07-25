using FlippingCoins.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace FlippingCoins.Controllers
{
    public enum face
    {
        Heads, Tails
    }
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index(Coin coin)
        {
            int num;
            Random r = new Random();

            num = r.Next(2);
            if (num == 0)
            {
                coin.upside = face.Heads;
                coin.downside = face.Tails;
            }
            else
            {
                coin.upside = face.Tails;
                coin.downside = face.Heads;

            }

            ViewBag.a = coin.upside;
            ViewBag.b = coin.downside;
            return View();
        }

        public IActionResult Privacy(Coin coin)
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