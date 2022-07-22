using Microsoft.EntityFrameworkCore;
using WebCoin.Models;

namespace WebCoin.Controllers
{
	public class DataContext:DbContext
	{
		public DataContext(DbContextOptions<DataContext> options):base(options)
		{

		}
		public DbSet<CoinModel> Coins { get; set; }
		
	}
}
