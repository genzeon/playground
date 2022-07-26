using CoinWebApp.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace CoinWebApp.Controllers
{
    public class HomeController : Controller
    {
        Data _db;
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult Flip()
        {
            Coin coin = new Coin();
            coin.Flip();
            CoinDB cointb = new CoinDB();
            cointb.Name = coin.Name;
            cointb.FlipCount = coin.FlipCount;
            cointb.FacingValue = (int)coin.Up;
            _db.Add(cointb);

            _db.SaveChanges();
            return RedirectToAction("coinstimulate", "Home");
            return View();
        }
        public IActionResult CoinStimulate()
        {
            var status = _db.CoinDBs.ToList();

            return View(status);
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}