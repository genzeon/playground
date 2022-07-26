using CoinFlipDemoApp;
using CoinFlipwebPart.Data;
using CoinFlipwebPart.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace CoinFlipwebPart.Controllers
{
    public class HomeController : Controller
    {
        private readonly ICoinFlip _Ic;
        private readonly CoinContext cContext;
        private readonly ILogger _logger;
        public HomeController(ILogger<HomeController> logger,ICoinFlip Ic ,CoinContext _coinContext)
        {
            _logger = logger;
            _Ic= Ic;
            cContext = _coinContext;
        }
      
        public IActionResult Index()
        {
            _Ic.SetSides();
            return View(_Ic);
        }
        [HttpPost]
        public IActionResult Index(string Name)
        {
            CoinToss ct= new CoinToss();
            bool t;
            _Ic.Flip();
            _logger.Log(LogLevel.Warning, "After Flipping");
            if (_Ic._Up == "Heads")
            {
              t = true;
            }
            else
            {
                t = false;
            }
            ct.Name = Name;
            ViewBag.Name = Name;
            ct.FaceUp = t;
            cContext.Add(ct);
            cContext.SaveChanges();
            ViewBag.TotalCount = TotalCount();
            ViewBag.NameCountt=NameCount(Name);
            ViewBag.TotalHeadss=TotalHeads(Name);
            ViewBag.TotalTailss=TotalTails(Name);
            return View(_Ic);
        }
        public int TotalCount()
        {
            return cContext.CoinToss.Count();
        }
        public int NameCount(string name)
        {
            int NCount = 0;
            var Cname = cContext.CoinToss;
            foreach (var c in Cname)
            {
                if(c.Name == name)
                {
                    NCount++;
                }
            }

            return NCount;
        }
        public int TotalHeads(string name)
        {
            int THeads = 0;
            var Tdata=cContext.CoinToss;
            foreach(var c in Tdata)
            {
                if(c.Name == name)
                {
                    if(c.FaceUp == false)
                    {
                        THeads++;
                    }
                }
            }
            return THeads;
        }
        public int TotalTails(string name)
        {
            int TTails = 0;
            var Tdata = cContext.CoinToss;
            foreach (var c in Tdata)
            {
                if (c.Name == name)
                {
                    if (c.FaceUp == true)
                    {
                        TTails++;
                    }
                }
            }
            return TTails;
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