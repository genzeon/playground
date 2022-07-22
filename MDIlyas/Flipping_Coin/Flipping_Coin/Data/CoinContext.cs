using Microsoft.EntityFrameworkCore;
using Flipping_Coin.Models;

namespace Flipping_Coin.Data
{
    public class CoinContext : DbContext
    {
        public CoinContext(DbContextOptions<CoinContext> options) : base(options) { }

        public DbSet<Toss> Coins { get; set; }

    }
}
