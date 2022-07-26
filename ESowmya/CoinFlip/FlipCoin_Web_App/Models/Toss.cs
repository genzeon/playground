using System.ComponentModel.DataAnnotations;


namespace FlipCoin_Web_App.Models
{
    public class Toss
    {
        [Key]
        public int Id { get; set; }
        
        public string CoinName { get; set; }

        public bool Facingup { get; set; }

        public int TryCount { get; set; }
    }
}
