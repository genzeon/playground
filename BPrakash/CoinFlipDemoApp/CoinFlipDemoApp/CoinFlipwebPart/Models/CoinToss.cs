using System.ComponentModel.DataAnnotations;

namespace CoinFlipwebPart.Models
{
    public class CoinToss
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public bool FaceUp { get; set; }
        public int TryCount { get; set; }
    }
}
