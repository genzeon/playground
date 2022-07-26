using Fliping_Coin_Using_Web_Application.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Fliping_Coin_Using_Web_Application.Controllers
{
    public class HomeController : Controller
    {


         private readonly ILogger<HomeController> _logger;
        public readonly Data context;
        public readonly Coin coin = new Coin();
        public HomeController(ILogger<HomeController> logger ,Data _context)
        {
            
            _logger = logger;
            context = _context;
            //coin = _c;
        }

        public IActionResult Index()
        {
           // coin.set_Intial_Stage();
            int count = context.Tosses.Count();
             ViewBag.TotalCount = count;
           // ViewBag.Up = coin.Up;
           // ViewBag.Down = coin.Down;
          //  var HeadsCount = context.Tosses.Where(t => t.Up == "Heads").Count();
           // var TailsCount = context.Tosses.Where(t => t.Down == "Tails").Count();
            return View(coin);
        }

        //" [Bind("Name")] Toss T\\
        //string name = "Akhil"
        public IActionResult Flip(string name = "Akhil")
        {
            coin.flip();
            
            Toss Ts = new Toss();
            Ts.Name = name;
            Ts.FaceValue = (int)coin.Up;
            Ts.TossCount = coin.Counts;
            context.Add(Ts);
            context.SaveChanges();
            _logger.Log(LogLevel.Information, "My Name is akhil");

            return RedirectToAction("CoinData", "Home");
        }
        [HttpPost]
        public IActionResult Index(Toss toss)
        {
            coin.flip();
            context.Add(toss);
            context.SaveChanges();
           int count = context.Tosses.Count();
            ViewBag.TotalCount = count;

            //ViewBag.Up = coin.Up;
          //  ViewBag.Down = coin.Down;
          //  var HeadsCount = context.Tosses.Where(t => t.Up == "Heads").Count();
            //var TailsCount = context.Tosses.Where(t => t.Down == "Tails").Count();
            return View(coin);

        }
        public IActionResult CoinData()
        {

            var A = context.Tosses.ToList();
            return View(A);
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