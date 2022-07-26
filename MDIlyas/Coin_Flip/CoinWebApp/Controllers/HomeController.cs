using CoinWebApp.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Coin_Flip;
namespace CoinWebApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ICoinFlip _coin;

        public HomeController(ICoinFlip coin)
        {
            _coin = coin;
        }

        public IActionResult Index()
        {
            return View();
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