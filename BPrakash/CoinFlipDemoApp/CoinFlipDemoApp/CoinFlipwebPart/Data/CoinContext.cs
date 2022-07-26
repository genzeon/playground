using Microsoft.EntityFrameworkCore;
using CoinFlipwebPart.Models;
namespace CoinFlipwebPart.Data
{
    public class CoinContext : DbContext
    {
        public CoinContext(DbContextOptions<CoinContext>options) : base(options) { }
        public DbSet<CoinToss> CoinToss { get; set; }
    }
}
