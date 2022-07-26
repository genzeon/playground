namespace CoinWebApp.Models
{
    public class Toss
    {
        public int Id { get; set; }
        public string CoinName { get; set; }
        public bool FacingUp { get; set; }
        public int TryCount { get; set; }
    }
}
