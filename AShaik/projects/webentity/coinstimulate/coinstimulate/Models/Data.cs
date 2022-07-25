using Microsoft.EntityFrameworkCore;

namespace coinstimulate.Models
{
    public class Data : DbContext
    {

        public Data(DbContextOptions<Data> options)
            : base(options)
        {
        }


        public DbSet<Coindb> Coindb { get; set; }


        //protected override void OnConfiguring(DbContextOptionsBuilder op)
        //{

        //    op.UseSqlServer(@"server=SHAIKAAKHEEL;database=CoinStimulatetest;integrated security = true");
        //}

    }
}
