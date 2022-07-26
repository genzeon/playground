using System;

namespace Flpping
{
    public enum CoinFace {Heads, Tails }
    public class Coin
    {

        private int _toss;
        CoinFace _up, _down;
        public CoinFace Up
        { 
            get { return _up; }
            set { _up = value; }    
        }
        public int Toss
        {
            get { return _toss; }
            set { _toss = value; }
        }
        public CoinFace Down
        {
            get { return _down; }
            set { _down = value; }  
        }
        public Coin()
        { 
           Up = CoinFace.Heads;
            Down = CoinFace.Tails;  
        }
        public override string ToString()
        {
            string str = $"Up:{Up}    Down:{Down}";
            return str; 
        }
        public void flip()
        {
            Random rand = new Random();
            int result = rand.Next(2);
            if (result == 0)
            {
                Up=CoinFace.Heads;  
                Down=CoinFace.Tails;    
            }
            else
            {
                Up= CoinFace.Tails;
                Down = CoinFace.Heads;

            }
        }
        static void Main(string[] args)
        {
            Coin c =new Coin();
            //Console.WriteLine("Before flip:");
            //Console.WriteLine(c.ToString());
            //Console.WriteLine("After fLip:");
            for (int i = 0; i <= 100; i++)
            {
                c.flip();
                Console.WriteLine(c.ToString());
            }
            Console.ReadLine();
        }
       
    }
}
