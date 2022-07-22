using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using TossingOfACoin.Models;

namespace TossingOfACoin.Controllers
{
    public enum sides 
    { 
        Heads = 0, 
        Tails 
    }
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index(Fliping flp )
        {
            Random rdm = new Random();
            if (rdm.Next(2) == 0)
            {
                flp.upside = sides.Heads;
                flp.downside = sides.Tails;
            }
            else
            {
                flp.upside = sides.Tails;
                flp.downside = sides.Heads;
            }

            ViewBag.A=flp.upside;
            ViewBag.B=flp.downside;
            return View(flp);
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