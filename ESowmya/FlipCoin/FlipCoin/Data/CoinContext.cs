using Microsoft.EntityFrameworkCore;
using FlipCoin.Models;


namespace FlipCoin.Data
{
    public class CoinContext:DbContext
    {
        public CoinContext(DbContextOptions<CoinContext> options):base(options)
        {
            
        }
        public DbSet<Toss> Coins { get; set; }

    }
}
