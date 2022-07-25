using Microsoft.EntityFrameworkCore;

namespace CoinWebApp.Models
{
    public class Data : DbContext
    {
        public Data(DbContextOptions<Data> option):base(option)
        {

        }
        public DbSet<CoinDB> CoinDBs { get; set; }
    }
}
