namespace CoinFlippingDemoApp.Models
{
    enum Sides
    {
        Heads, Tail
    }
    internal class Coin
    {
        public Coin() { }
        private string Up;
        public string _Up
        {
            get { return Up; }
            set { Up = value; }
        }
        private string Down;
        public string _Down
        {
            get { return Down; }
            set { Down = value; }
        }
        public void SetSides()
        {
            Up = Sides.Heads.ToString();
            Down = Sides.Tail.ToString();
        }
        public override string ToString()
        {
            return "The UpSide of the Coin is: " + Up + " and the down side of the Coin is: " + Down;

        }
        
        public void Flip()
        {
            Random rnd = new Random();
            int num = rnd.Next(2);
            if (num == 0)
            {
                Up = Sides.Heads.ToString();
                Down = Sides.Tail.ToString();
            }
            else
            {
                Down = Sides.Heads.ToString();
                Up = Sides.Tail.ToString();
            }
        }

    }
}
