using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebCoin.Models;
using Microsoft.EntityFrameworkCore;
using PlayingWithCoin;


namespace WebCoin.Controllers
{
	public class HomeController : Controller
	{

		private readonly DataContext _context;

		public HomeController(DataContext context)
		{
			_context = context;
		}

		public IActionResult Index()
		{
			return View();
		}
		[HttpPost]
		public IActionResult Index(CoinModel value)
		{
			int Counter=1;
			Coin coin = new Coin();
			value.No_Of_Toss = Counter;
			value.Occurence = Convert.ToBoolean(coin.FacingUpside);
			if (ModelState.IsValid)
			{
				_context.Add(coin);
				_context.SaveChangesAsync();
			}
			Counter++;
			return View(coin);
		}		
	}
}