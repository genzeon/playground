
using Microsoft.EntityFrameworkCore;
using WebAppForCoin.Models;

namespace WebAppForCoin.Controllers
{
	public class CoinDBContext:DbContext
	{
		public CoinDBContext(DbContextOptions<CoinDBContext> options):base()
		{

		}
		public DbSet<CoinModel> Tosses { get; set; }
		public DbSet<CoinModel> OccuredOutputs { get; set; }
	}
}
