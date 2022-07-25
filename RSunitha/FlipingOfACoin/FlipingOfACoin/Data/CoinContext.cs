using Microsoft.EntityFrameworkCore;

using FlipingOfACoin.Models;


namespace FlipingOfACoin.Data
{
        public class CoinContext : DbContext
        {
        public CoinContext(DbContextOptions<CoinContext> options) : base(options) { }
        public DbSet<Toss> Coins { get; set; }
        }
    
}
