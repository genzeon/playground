using System.ComponentModel.DataAnnotations;

namespace COIN_FLipping.Models
{
    public class CoinToss
    {
        [Key]
        [Required]
        public int Toss { get; set; }
        [Required]
        public string Value { get; set; }
    }
}
