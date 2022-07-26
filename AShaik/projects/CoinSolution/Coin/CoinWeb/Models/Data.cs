using Microsoft.EntityFrameworkCore;

namespace CoinWeb.Models
{
    public class Data:DbContext
    {
        public Data(DbContextOptions<Data> options):base(options)
        {

        }
        public DbSet<CoinDB> CoinDBs { get; set; }
    }
}
