using System.ComponentModel.DataAnnotations;

namespace CoinWeb.Models
{
    public class CoinDB
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public int FaceUp { get; set; }
        public int TossCount { get; set; }

    }
}
