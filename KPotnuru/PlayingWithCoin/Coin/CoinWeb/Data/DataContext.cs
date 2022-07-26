using CoinWeb.Models;
using Microsoft.EntityFrameworkCore;

namespace CoinWeb.Data
{
	public class DataContext:DbContext
	{
		public DataContext(DbContextOptions<DataContext> options) : base(options)
		{

		}
		public DbSet<Occurence> TossResults { get; set; }
	}
}
