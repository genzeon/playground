using Microsoft.EntityFrameworkCore;
using TossingOfACoin.Models;

namespace TossingOfACoin.Data
{
    public class DataContest:DbContext

    {
        public DataContest(DbContextOptions<DataContest> options ): base(options)
        {
            
        }
        public DbSet<Toss> toss { get; set; }
    }
}
