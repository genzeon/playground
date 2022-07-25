using FlipCoin.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using FlipCoin.Data;

namespace FlipCoin.Controllers
{
    public class HomeController : Controller
    {
        private readonly Coin coin=new Coin();
        private readonly CoinContext _coinDb;

        

        public HomeController(CoinContext coin)
        {
            _coinDb=coin;
        }

           
        public IActionResult Index()
        {
            coin.set_intial_value();
           var coincount=_coinDb.Coins.Count();
            ViewBag.Count=coincount;
            return View(coin);
        }
        [HttpPost]

        public IActionResult Index(Toss _toss)
        {
            coin.Flip();
            _coinDb.Add(_toss);
            _coinDb.SaveChanges();
            var coincount = _coinDb.Coins.Count();
            ViewBag.Count = coincount;
            var coindata=_coinDb.Coins;
            var Headcount = 0;
            var TailCount=0; 
            foreach (var i in coindata)
            {
                if (i.Up == "Heads")
                {
                    Headcount++;
                }
                else
                {
                    TailCount++;
                }
            }
            ViewBag.Headcount=Headcount;
            ViewBag.Tailcount=TailCount;
            return View(coin);

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