namespace CoinWebApp.Models
{
    public enum Sides
    {
        Heads = 1, Tails
    }
    public class Coin
    {
        Sides _up;
        Sides _down;
        string _name;
        int _flipCount;
        public Sides Up
        {
            get
            {
                return _up;
            }
            set
            {
                _up = value;
            }
        }
        public Sides Down
        {
            get
            {
                return _down;
            }
            set
            {
                _down = value;
            }
        }
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public int FlipCount
        {
            get { return _flipCount; }
            set { _flipCount = value; }
        }
        public Coin()
        {
            Up = Sides.Heads;
            Down = Sides.Tails;
        }
        public override string ToString()
        {
            string str = $"up={this.Up}  Down= {this.Down}";
            return str;
        }
        public string Flip()
        {
            Random random = new Random();
            int num = random.Next(2);
            if (num == 0)
            {
                Up = Sides.Heads;
                Down = Sides.Tails;
            }
            else
            {
                Up = Sides.Tails;
                Down = Sides.Heads;
            }
            return ToString();
        }
    }
}
