using System.ComponentModel.DataAnnotations; 

namespace CoinFlippingDemoApp.Models;

public class Flip
{
    [Key]
    public int flip { get; set; }
    public string _Up { get; set; }
    public string _Down { get; set; }
}
