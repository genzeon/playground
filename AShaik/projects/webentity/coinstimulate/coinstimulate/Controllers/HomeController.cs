using coinstimulate.Models;
using coinstimulate.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace coinstimulate.Controllers
{
    public class HomeController : Controller
    {

        Data db;
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger, Data _db)
        {
            _logger = logger;
            this.db = _db;
        }

        public IActionResult Index()
        {
          
            return View();
        }

        public IActionResult Privacy()
        {

           
            return View();
        }

        public IActionResult flip()
        {
            coin c = coin.Instance;
            //var chk = db.Cointables.Count();


            //if (chk!=0 )
            //{
   
            //    var qheadscount = db.Cointables.Where(p => p.Facevalue == "heads").Count();
            //    var qtailscount = db.Cointables.Where(p => p.Facevalue == "tails").Count();
            //    var qtosscount = db.Cointables.Count();
            //    var qlasttossresult = db.Cointables.OrderByDescending(p => p.Facevalue).FirstOrDefault().Facevalue;


            //    c.Toss = qtosscount;
            //    if (qlasttossresult == "heads")
            //    {
            //        c.Up = (Coinface)1;
            //        c.Down = (Coinface)2;
            //    }
            //    else
            //    {
            //        c.Up = (Coinface)2;
            //        c.Down = (Coinface)1;
            //    }


            //    c.Headcount = qheadscount;
            //    c.Tailcount = qtailscount;
  
            //}

            c.flip();

           
            Coindb cointable = new Coindb();
            cointable.Name = c.Name;
            cointable.FaceUp = (int)c.Up;
            cointable.TossCount = c.Toss;



            db.Add(cointable);

            db.SaveChanges();
            return RedirectToAction("coinstimulate", "Home");
            return View();
        }
        public IActionResult coinstimulate()
        {
            var qone = db.Coindb.ToList();

            return View(qone);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}