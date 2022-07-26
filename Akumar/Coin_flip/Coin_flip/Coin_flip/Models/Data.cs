using Microsoft.EntityFrameworkCore;
using Coin_flip.Models;

namespace Coin_flip.Models
{
    public class Data : DbContext
    {
        public Data(DbContextOptions<Data>options) :base(options)
        {

        }
        public DbSet<CoinDataBase> Tosses { get; set; } 
    }
    
}
