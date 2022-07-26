using System.ComponentModel.DataAnnotations;

namespace Coin_flip.Models
{
    public class CoinDataBase
    {
        [Key]
        public int Toss { get; set; }
       
        public string Up { get; set; }

        public string Down { get; set; }    

        
    }
}
