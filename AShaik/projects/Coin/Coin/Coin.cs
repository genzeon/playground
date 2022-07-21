using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coin
{
    internal class Coin
    {
    }
}


namespace Coins
{


    public enum Coinface
    {
        heads = 1, tails
    }

    public class coin
    {


        public Coinface face;

        public Coinface Up
        {
            get
            {
                return Coinface.heads;
            }
            set
            {
                face = Coinface.heads;
            }
        }
        public Coinface Down
        {
            get
            {
                return Coinface.tails;
            }
            set
            {
                face = Coinface.tails;
            }
        }

        public coin()
        {
            Up = Coinface.heads;
            Down = Coinface.tails;


        }
        public override string ToString()
        {
            string str = $"up=" + this.Up + "," + "Down=" + this.Down;
            return str;
        }

        public void flip()
        {
            int num = 0;

            Random random = new Random();
            num = random.Next(0, 2);
            Console.WriteLine(num);
            if (num == 0)
            {
                Up = Coinface.heads;
                Down = Coinface.tails;
            }
            else
            {
                Console.WriteLine("else method is called");
                Up = Coinface.tails;
                Down = Coinface.heads;
            }



        }

        public string display()
        {
            return null;
        }
    }

}
