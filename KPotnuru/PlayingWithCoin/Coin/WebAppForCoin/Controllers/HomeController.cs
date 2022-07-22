using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebAppForCoin.Models;
using PlayingWithCoin;

namespace WebAppForCoin.Controllers
{
	public class HomeController : Controller
	{
		

		public IActionResult Index()
		{
			
			
			return View();
		}
		public IActionResult Add()
		{
			Coin coin = new Coin();
			coin.filp();
			return View();
		}
	}
}