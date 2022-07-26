using Microsoft.EntityFrameworkCore;

namespace CoinBWeb.Data
{
    public class Data:DbContext
    {
        public Data(DbContextOptions<Data> options):base(options)
        {

        }
       
        public DbSet<CoinDB> CoinDBs { get; set; }
    }
}
