using System.ComponentModel.DataAnnotations;

namespace CoinBWeb.Data
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
