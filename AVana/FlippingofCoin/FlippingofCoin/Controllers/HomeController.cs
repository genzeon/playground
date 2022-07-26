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

        public HomeController(DataContext dcon , Flipping flp)
        {
            
          Dcon = dcon;
            _flp = flp;
        }

        public IActionResult Index()
        {
            _logger.LogInformation("log Information");
            _logger.LogWarning("log Warning");
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
        public IActionResult coinstimulate()
        {
            var qone = Dcon.Flips.ToList();
            return View(qone);
        }
        public IActionResult Flip()
        {
            _flp.Flip();


            Toss ctb = new Toss();
            ctb.Name = "anusha";
            ctb.FaceUp = (int)_flp.Upside;
            ctb.Tosscount = _flp.toss;



            Dcon.Add(ctb);

            Dcon.SaveChanges();
            return RedirectToAction("coinstimulate", "Home");
            
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}