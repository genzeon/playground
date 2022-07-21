using System;

namespace Coin
{
    enum coinsides { Heads, Tails }
    internal class Coin
    {
        public coinsides face;

        public coinsides Up
        {
            get { return coinsides.Tails; }
            set { face = coinsides.Tails; }
        }
        public coinsides Down
        {
            get { return coinsides.Heads; }
            set { face = coinsides.Heads; }
        }
        public Coin(coinsides _up, coinsides _down)
        {
            Up = _up;
            Down = _down;
        
        }
        public override string ToString()
        {
           string str = $"Up="+this.Up+","+this.Down;
            return str; 
        }
        public void flip()
        {
            Random rand = new Random();
            int result = rand.Next(0, 2);
            if (result == 0)
            {
                Up = coinsides.Heads;
                Console.WriteLine(Up);
            }
            else
            {
                Down = coinsides.Tails;
                Console.WriteLine(Down);
            }
        }


        static void Main(string[] args)
        {
           coinsides cs = coinsides.Tails;  
            coinsides cs1 = coinsides.Heads;
            Coin c = new Coin(cs,cs1);
            c.flip();
            Console.WriteLine(c.ToString());
            Console.ReadLine(); 
           
        }
    }
}
