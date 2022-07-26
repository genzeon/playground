using FlipCoin_Web_App.Models;
using Microsoft.AspNetCore.Mvc;
using CoinFlip;
using FlipCoin_Web_App.Data;
using System.Diagnostics;

namespace FlipCoin_Web_App.Controllers
{
    public class HomeController : Controller
    {
        private readonly ICoin coin;

        private readonly CoinContext _coindb;

        
        public HomeController(CoinContext coindb,ICoin _coin)
        {
            _coindb = coindb;
            coin = _coin;
            
        }

        public IActionResult Index()
        {
            coin.set_intial_value();
            ViewBag.TotalCount = TotalCount();

            return View(coin);
        }

        [HttpPost]
        public IActionResult Index(string CName)
        {
            Toss _toss = new Toss();
            coin.Flip();
            bool i;
            if (coin.Up == "Heads")
            {
                i = true;   
            }
            else
            {
                i= false;
            }
            _toss.CoinName = CName;
            ViewBag.Name = CName;
            _toss.Facingup = i;
            _coindb.Add(_toss);
            _coindb.SaveChanges();

            ViewBag.CoinCount = CoinCount(CName);
            ViewBag.TotalCount = TotalCount();
            ViewBag.HCount=HeadCount(CName);
            ViewBag.TCount = TailCount(CName);
            return View(coin);
        }

        public int CoinCount(string name)
        {
            
            var CoinData = _coindb.Toss;
            int count = 0;
            foreach(var i in CoinData)
            {
                if (i.CoinName == name)
                {
                    count++;
                }
            }
            
            return count;
        }
        public int TotalCount()
        {
            var totalcount = _coindb.Toss.Count();

            return totalcount;
        }
        

        public int HeadCount(string name)
        {
            var Headcount = _coindb.Toss;
            int HCount = 0;
            foreach(var i in Headcount)
            {
                if (i.Facingup == true)
                {
                    HCount++;

                }
            }
            return HCount;
        }

        public int TailCount(string CName)
        {
            var TailCount = _coindb.Toss;
            int TCount=0;
            foreach (var i in TailCount)
            {
                if (i.Facingup == false)
                {
                    TCount++;
                }
            }
            return TCount;
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