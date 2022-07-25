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
            var Coincount = _coinDb.Coins.Count();
            ViewBag.Coincount = Coincount;
            ViewBag.HeadsCount = HeadsCount();
            ViewBag.TailsCount = TailsCount();
            return View(coin);
        }
        
        [HttpPost]

        public IActionResult Index(Toss _toss)
        {
            coin.Flip();
            _coinDb.Add(_toss);
            _coinDb.SaveChanges();
            var Coincount = _coinDb.Coins.Count();
            ViewBag.Coincount = Coincount;
            ViewBag.HeadsCount = HeadsCount();
            ViewBag.TailsCount = TailsCount();
            return View(coin);
        }

        public int HeadsCount()
        {
            var Coincount = _coinDb.Coins;
            var count = 0;
            foreach(var row in Coincount)
            {
                if(row.facing_up.ToLower() == "heads")
                {
                    count++;
                }
            }
            return count;
        }

        public int TailsCount()
        {
            var Coincount = _coinDb.Coins;
            var count = 0;
            foreach (var row in Coincount)
            {
                if (row.facing_up.ToLower() == "tails")
                {
                    count++;
                }
            }
            return count;
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