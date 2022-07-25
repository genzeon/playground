using FlipingOfACoin.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using FlipingOfACoin.Data;


namespace FlipingOfACoin.Controllers
{

    public class HomeController : Controller
    {
        private readonly Coin c = new Coin();
        private readonly CoinContext _coinContext;


        public HomeController(CoinContext coinContext)
        {
            _coinContext = coinContext;
        }

        public IActionResult Index()
        {
            c.IntialSides();
            var Coin = _coinContext.Coins.Count();
            c.ToString();
            ViewBag.Coin = c.ToString();
            return View(c);
        }
        [HttpPost]

        public IActionResult Index(Toss _toss)
        {
            c.Flip();
            _coinContext.Add(_toss);
            _coinContext.SaveChanges();
            var coincount = _coinContext.Coins.Count();
            ViewBag.Count = coincount;
            var coindata = _coinContext.Coins;
            var Headcount = 0;
            var Tailcount = 0;
            foreach (var i in coindata)
            {
                if (i.Upside == "Heads")
                {
                    Headcount++;

                }
                else
                {
                    Tailcount++;
                }
            }
            ViewBag.Headcount = Headcount;  
            ViewBag.Tailcount = Tailcount;  
                return View(c);
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
