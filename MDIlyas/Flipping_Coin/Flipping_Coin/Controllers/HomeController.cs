using Flipping_Coin.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Flipping_Coin.Data;

namespace Flipping_Coin.Controllers
{
    public class HomeController : Controller
    {

        private readonly Coin coin = new Coin();

        private readonly CoinContext _coinDb;

        public HomeController(CoinContext _coin)
        {
            _coinDb = _coin;
        }

        public IActionResult Index()
        {
            coin.setInitialValues();
            ViewBag.FlipRes = coin.ToString();
            return View();
        }
        
        [HttpPost]

        public IActionResult Index(int? a)
        {
            coin.Flip();
            ViewBag.FlipRes = coin.ToString();
            Toss toss = new Toss(coin.Up.ToString(), coin.Down.ToString());
            _coinDb.Add(toss);
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