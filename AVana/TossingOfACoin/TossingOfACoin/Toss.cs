using System.ComponentModel.DataAnnotations;

namespace TossingOfACoin
{
    public class Toss
    {
        [Key]
        public int toss { get; set; }
        public string upside { get; set; }
        public string downside { get; set; }
    }
}
