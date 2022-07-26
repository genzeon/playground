using CoinClass;
using CoinWeb.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace CoinBWeb.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private  Data _db;
        private  Coin _c;
        public HomeController(ILogger<HomeController> logger, Data db, Coin c)
        {
           _logger = logger;
            this._db=db;
            this._c=c;
        }

        public IActionResult Index()
        {
            _logger.LogError("err msg");
            _logger.LogInformation("err msg");
            _logger.LogWarning("err msg");
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult CoinData()
        {
            var q = _db.CoinDBs.ToList();
           
            return View(q);
        }
        [HttpPost]
        public IActionResult Flip(string name="aakheel")
        {
          
                _c.flip();
                CoinDB cdb = new CoinDB();
                cdb.Name = name;
                cdb.FaceUp = (int)_c.Up;
                cdb.TossCount = _c.Toss;
                _db.Add(cdb);
                _db.SaveChanges();
                return RedirectToAction("CoinData", "Home");

        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}