using CoinFlippingDemoApp.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using CoinFlippingDemoApp.Data;

namespace CoinFlippingDemoApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly Coin c = new Coin();
        private readonly CoinContext cContext;
        public HomeController(CoinContext _coinContext)
        {
            cContext = _coinContext;
        }

        public IActionResult Index()
        {
            c.SetSides();
            var CountData= cContext.Coins.Count();
            ViewBag.Count=CountData;
            return View(c);
        }
        [HttpPost]
        public IActionResult Index(Flip flips)
        {
            c.Fliip();
            cContext.Add(flips);
            cContext.SaveChanges();
            var CountData = cContext.Coins.Count();
            ViewBag.Count = CountData;
            var CountData2 = cContext.Coins;
            var HeadCount = 0;
            var TailCount = 0;
            foreach(var HTCount in CountData2)
            {
                if (HTCount._Up == "Heads")
                {
                    HeadCount++;
                }
                else
                {
                    TailCount++;
                }
            }
            ViewBag.HeadCount=HeadCount;
            ViewBag.TailCount=TailCount;
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