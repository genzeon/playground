using System.ComponentModel.DataAnnotations;

namespace COIN_FLipping.Models
{
    public class CoinToss
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public int FaceUp { get; set; }
        public int TossCount { get; set; }


    }
}
