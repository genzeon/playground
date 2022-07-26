using COIN_FLipping.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Flpping;


namespace COIN_FLipping.Controllers
{
    public class HomeController : Controller
    {
        DataContext context;
        private Coin c;
        public HomeController(DataContext _context, Coin _c)
        {
            context=_context;
            this.c=_c;
        }

        public IActionResult CoinData()
        {
            var q = context.Toss.ToList();

            return View(q);
        }
        public IActionResult Flip()
        {
          
            return View();
        }
        [HttpPost]
        public IActionResult Flip(CoinToss entity)
        {
            c.flip();
            CoinToss ct = new CoinToss();
            ct.Name = entity.Name;
            ct.FaceUp = (int)c.Up;
            ct.TossCount = context.Toss.Where(a=>a.Name==entity.Name).Count()+1;
            context.Add(ct);
            context.SaveChanges();
            CoinData();
           // return RedirectToAction("CoinData", "Home");
           return View();
        }


        public IActionResult Index()
        {
            var rows = context.Toss;
            foreach (var row in rows)
            {
                context.Toss.Remove(row);
            }
            context.SaveChanges();
            ViewBag.SideUp = c.Up;
            ViewBag.SideDown = c.Down;
            return View();
        }
        //[HttpPost]
        //public IActionResult Index(CoinToss tossValue)
        //{
        //    c.flip();
        //    tossValue.Value = c.Up.ToString();
        //    tossValue.Toss = context.Toss.Count() + 1;
        //    context.Add(tossValue);
        //    context.SaveChanges();
        //    ViewBag.HeadsCount = context.Toss.Where(a => a.Value == "Heads").Count();
        //    ViewBag.TailsCount = context.Toss.Where(a => a.Value == "Tails").Count();
        //    ViewBag.SideUp = c.Up;
        //    ViewBag.SideDown = c.Down;
        //    return View();
        //}

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}