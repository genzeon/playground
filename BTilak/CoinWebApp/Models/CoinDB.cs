using System.ComponentModel.DataAnnotations;

namespace CoinWebApp.Models
{
    public class CoinDB
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public int FlipCount { get; set; }
        public int FacingValue { get; set; }
    }
}
