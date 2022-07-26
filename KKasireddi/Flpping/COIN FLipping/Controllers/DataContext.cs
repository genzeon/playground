using COIN_FLipping.Models;
using Microsoft.EntityFrameworkCore;


namespace COIN_FLipping.Controllers
{
    public class DataContext:DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }
        public DbSet<CoinToss> Toss { get; set; }
    }
}
