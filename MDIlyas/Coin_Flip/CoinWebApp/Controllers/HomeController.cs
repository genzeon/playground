using CoinWebApp.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Coin_Flip;
using CoinWebApp.Data;
using CoinWebApp.Models;

namespace CoinWebApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ICoinFlip _coin;
        private readonly CoinContext _db;
        private readonly ILogger<HomeController> _logger;

        public HomeController(ICoinFlip coin, CoinContext db, ILogger<HomeController> logger)
        {
            _coin = coin;
            _db = db;
            _logger = logger;
        }

        public IActionResult Index()
        {
            _coin.set_initial_Sides();
            ViewBag.TotalCountCount = TotalCount();
            ViewBag.TotalCount = TotalCount();

            _logger.LogInformation("Starting Log Information");

            return View(_coin);
        }

        [HttpPost]

        public IActionResult Index(string Name)
        {
            _coin.Flip();
            bool coinSide;
            if (_coin.Up.ToLower() == "heads")
            {
                coinSide = true;
            }
            else
            {
                coinSide = false;
            }
            Toss _toss = new Toss();
            _toss.FacingUp = coinSide;
            _toss.CoinName = Name;
            _toss.TryCount = _coin.Count();
            _db.Add(_toss);
            _db.SaveChanges();

            ViewBag.TotalCount = TotalCount();
            ViewBag.CountOfCoin = CountOfCoin(Name);
            ViewBag.HeadsCount = HeadsCount(Name);
            ViewBag.TailsCount = TailsCount(Name);

            ViewBag.Name = Name;
            return View(_coin);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public int TotalCount()
        {
            return _db.CoinFlip.Count();
        }
        public int CountOfCoin(string name)
        {
            int totalCount = 0;

            var CoinData = _db.CoinFlip;
            foreach (var coin in CoinData)
            {
                if(coin.CoinName == name)
                {
                    totalCount++;
                }
            }

            return totalCount;
        }

        public int HeadsCount(string name)
        {
            var CoinData = _db.CoinFlip;
            int headsCount = 0;
            foreach(var coin in CoinData)
            {
                if(coin.CoinName == name)
                {
                    if(coin.FacingUp == true)
                    {
                        headsCount++;
                    }
                }
            }
            return headsCount;
        }
        public int TailsCount(string name)
        {
            var CoinData = _db.CoinFlip;
            int TailsCount = 0;
            foreach(var coin in CoinData)
            {
                if(coin.CoinName == name)
                {
                    if(coin.FacingUp == false)
                    {
                        TailsCount++;
                    }
                }
            }
            return TailsCount;
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}