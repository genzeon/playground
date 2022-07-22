using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pendlium
{
    public class Coin
    {
        Face _Up;
        Face _Down;

        public Face Up
        {
            get
            {
                return _Up;
            }
            set
            {
                _Up = value;
            }

        }
        Face Down
        {
            get
            { 
                return _Down; 
            }
            set
            {
                _Down = value;
            }
        }
    
        public Coin()
        {
            Up = Face.Heads;
            Down = Face.Tails;
        }
        public override string ToString()
        {
            return $"Up={Up}, Down={Down}";
        }

        public void Flip()
        {
            Random random = new Random();
            if (random.Next(2) == 0)
            {
                Up = Face.Heads;
                Down = Face.Tails;
            }
            else
            {
                Up = Face.Tails;
                Down = Face.Heads; 
            }
        }
    }

    public enum Face {Heads, Tails };
}
