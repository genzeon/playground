using Flpping;
using Microsoft.EntityFrameworkCore;


namespace COIN_FLipping.Controllers
{
    public class DataContext:DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }
        public DbSet<Coin> Toss { get; set; }
    }
}
