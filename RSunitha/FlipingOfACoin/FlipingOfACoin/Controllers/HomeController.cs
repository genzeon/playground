using FlipingOfACoin.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace FlipingOfACoin.Controllers
{
   public enum face
    {
        Heads,Tails
    }
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index(Coin Coin)
        {
            int num;
            Random random = new Random();

            num = random.Next(2);
            if(num == 0)
            {
                Coin.Upside = face.Heads;
                Coin.Downside = face.Tails;   
            }
            else
            {
                Coin.Upside = face.Tails;
                Coin.Downside = face.Heads; 
            }

            ViewBag.a = Coin.Upside;
            ViewBag.b = Coin.Downside;  
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