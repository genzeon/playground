using CoinWeb.Data;
using CoinWeb.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using CoinClass;
using CoinWeb.Repositary;

namespace CoinWeb.Controllers
{
	public class HomeController : Controller
	{
		DataContext Context;
		CoinRepositary coinRepositary;
		Coin coin = new Coin();
		public HomeController(DataContext _Context, CoinRepositary _coinRepositary)
		{
			Context = _Context;
			coinRepositary = _coinRepositary;
		}

		public IActionResult Index()
		{

			ViewBag.Upside = coin.FacingUpside;
			ViewBag.DownSide =coin.FacingDownside;
			var rows = Context.TossResults;
			foreach (var row in rows)
			{
				Context.TossResults.Remove(row);
			}
			Context.SaveChanges();

			return View();
		} 
		
		int Count = 1;
		[HttpPost]
		public IActionResult Index(Occurence entity)
		{
			coin.filp();
			entity.Result = coin.FacingUpside.ToString();
			entity.No_Of_Toss = Context.TossResults.Count()+1;
			coinRepositary.Add(entity);
			coinRepositary.Save();
			var Heads = Context.TossResults.Where(a => a.Result == "Heads");
			ViewBag.HeadsCount = Heads.Count();
			var Tails = Context.TossResults.Where(a => a.Result == "Tails");
			ViewBag.TailsCount = Tails.Count();
			ViewBag.Upside = coin.FacingUpside;
			ViewBag.DownSide = coin.FacingDownside;
			ViewBag.No_Of_Tosses = Context.TossResults.Count();
			return View();
		}

		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		public IActionResult Error()
		{
			return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		}
	}
}