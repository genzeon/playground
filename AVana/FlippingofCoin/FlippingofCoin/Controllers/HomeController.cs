using FlippingofCoin.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using FlippingofCoin.Data;

namespace FlippingofCoin.Controllers
{
    public class HomeController : Controller
    {
        private readonly Flipping _flp;
        private readonly DataContext Dcon;
        private readonly ILogger _logger;

        public HomeController(DataContext dcon , Flipping flp, ILogger<HomeController> logger)
        {
            _logger= logger;
          Dcon = dcon;
            _flp = flp;
        }

        public IActionResult Index()
        {
            _logger.LogInformation("log Information");
            _logger.LogWarning("log Warning");
            _logger.Log(LogLevel.Warning, "After Flipping");
            return View();
        }
        //[HttpPost]

        //public IActionResult Index(Toss _toss)
        //{
        //    flp.Flip();
        //    Dcon.Add(_toss);
        //    Dcon.SaveChanges();
        //    var coincount = Dcon.Flips.Count();
        //    ViewBag.Count = coincount;
        //    var coindata = Dcon.Flips;
        //    var Headcount = 0;
        //    var Tailcount = 0;
        //    foreach (var c in coindata)
        //    {
        //        if (c.FaceUp == "Heads")
        //        {
        //            Headcount++;

        //        }
        //        else
        //        {
        //            Tailcount++;
        //        }
        //    }
        //    ViewBag.Headcount = Headcount;
        //    ViewBag.Tailcount = Tailcount;
        //    return View(flp);
        //}
        public IActionResult Privacy()
        {
            return View();
        }
       
        public IActionResult Flip(string Name)
        {
            Toss ctb = new Toss();
            _flp.Flip();
            string pname = Name;

            if(Name != null)
            {
                ctb.Name = Name;
            }
            else
            {
                ctb.Name = "Anusha";
            }

            ctb.FaceUp = (int)_flp.Upside;
            ctb.Tosscount = _flp.toss;



            Dcon.Add(ctb);

            Dcon.SaveChanges();
            return RedirectToAction("coinstimulate", "Home");
            
        }
        public IActionResult coinstimulate()
        {
            var qone = Dcon.Flips.ToList();
            return View(qone);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}