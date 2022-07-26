using CoinClass;
using CoinWeb.Data;
using CoinWeb.Models;
using CoinWeb.Repositary;
using Microsoft.AspNetCore.Mvc;

namespace CoinWeb.Controllers
{
	public class TossingController : Controller
	{
		DataContext Context;
		CoinRepositary coinRepositary;
		Coin coin = new Coin();
		ILogger logger;
		
		public TossingController(DataContext _Context, CoinRepositary _coinRepositary,ILogger<TossingController> _logger)
		{
			logger = _logger;
			Context = _Context;
			coinRepositary = _coinRepositary;
		}
		public IActionResult Toss()
		{
			logger.LogWarning("Toss having warning");
			logger.LogError("Toss having error");
			logger.LogInformation("Toss having information");
			return View();
		}
		[HttpPost]
		public IActionResult Toss(TossingTable entity)
		{
			logger.LogWarning("Toss having in post method warning");
			logger.LogError("Toss having in post method error");
			logger.LogInformation("Toss having in post method information");
			coin.filp();
			entity.FACE_VALUE = (int)coin.FacingUpside;
			entity.TRY = Context.TossingTable.Where(a => a.Name == entity.Name).Count() + 1;
			entity.Id = Context.TossingTable.Count() + 1;
			coinRepositary.Add(entity);
			coinRepositary.Save();
			return RedirectToAction("Display", entity);
		}
		public IActionResult Display(TossingTable entity)
		{
			
			var listofvalues = coinRepositary.GetAll(entity);
			return View(listofvalues);
		}

	}
}
