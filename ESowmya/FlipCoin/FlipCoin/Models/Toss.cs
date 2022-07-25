using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace FlipCoin.Models
{
    public class Toss
    {
        [Key]
        public int toss { get; set; }
        
        public string Up { get; set; }

        public string Down { get; set; }
        
    }
}
