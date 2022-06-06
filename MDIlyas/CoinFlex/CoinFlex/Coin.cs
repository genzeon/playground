using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoinFlex
{
    public class Coin
    {
        public string[] sides = { "Heads", "Tails" };
        public string Flip()
        {
            Random rnd = new Random();
            int number = rnd.Next(sides.Length);
            return sides[number];
        }

        static void Main(string[] args)
        {

        }
    }
}
