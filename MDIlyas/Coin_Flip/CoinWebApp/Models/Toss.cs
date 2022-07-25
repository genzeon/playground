namespace CoinWebApp.Models
{
    public class Toss
    {
        public int Flip { get; set; }
        public string CoinName { get; set; }
        public bool FacingUp { get; set; }
        public int TryCount { get; set; }
    }
}
