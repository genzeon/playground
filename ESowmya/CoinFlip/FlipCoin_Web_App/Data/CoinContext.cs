using Microsoft.EntityFrameworkCore;
using FlipCoin_Web_App.Models;

namespace FlipCoin_Web_App.Data
{
    public class CoinContext:DbContext
    {
        public CoinContext(DbContextOptions<CoinContext> options) : base(options)
        {

        }
        public DbSet<Toss> Toss { get; set; }
    }
}
