using Microsoft.EntityFrameworkCore;

namespace Fliping_Coin_Using_Web_Application.Models
{
    public class Data : DbContext
    {
        public Data(DbContextOptions<Data> options) : base(options)
        {

        }
        public DbSet<Toss> Tosses { get; set; }
    }
}
