using Microsoft.EntityFrameworkCore;
using CoinFlippingDemoApp.Models;


namespace CoinFlippingDemoApp.Data
{
    public class CoinContext : DbContext
    {
        public CoinContext(DbContextOptions<CoinContext> options) : base(options) { }
        public DbSet<Flip> Coins { get; set; }
    }
}
