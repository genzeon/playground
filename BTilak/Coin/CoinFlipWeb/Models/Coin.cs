using System;
namespace Coins
{
    public enum Sides
    {
        Heads = 1, Tails
    }
    public class Coin
    {
        Sides _upSide, _downSide;
        public Sides Up
        {
            get
            {
                return _upSide;
            }
            set
            {
                _upSide = value;
            }
        }
        public Sides Down
        {
            get
            {
                return _downSide;
            }
            set
            {
                _downSide = value;
            }
        }
        public Coin()
        {
            Up = Sides.Heads;
            Down = Sides.Tails;
        }
        public string Flip()
        {
            Random rand = new Random();
            int num = rand.Next(2);
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
            return $"Up side = {this.Up} and Down side  = {this.Down}";
        }
        public override string ToString()
        {
            string state = $"Up side = {this.Up} and Down side  = {this.Down}";
            return state;
        }
        static void Main()
        {
            Coin coin = new Coin();
            Console.WriteLine("Before Flip : ");
            Console.WriteLine(coin.ToString());
            Console.WriteLine("After Flip : ");
            for (int i = 1; i <= 100; i++)
            {
                coin.Flip();
                Console.WriteLine(coin.ToString());
            }
            Console.ReadLine();
        }
    }
}

