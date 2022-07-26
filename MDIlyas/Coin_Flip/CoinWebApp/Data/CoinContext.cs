using Microsoft.EntityFrameworkCore;
using CoinWebApp.Models;

namespace CoinWebApp.Data
{
    public class CoinContext : DbContext
    {
        public CoinContext(DbContextOptions<CoinContext> options) : base(options) { }
        public DbSet<Toss> CoinFlip { get; set; }
    }
}
