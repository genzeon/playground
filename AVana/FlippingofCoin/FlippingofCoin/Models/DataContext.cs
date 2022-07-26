using FlippingofCoin.Models;
using Microsoft.EntityFrameworkCore;

namespace FlippingofCoin.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }
        public DbSet<Toss> Flips { get; set; }

    }
}
