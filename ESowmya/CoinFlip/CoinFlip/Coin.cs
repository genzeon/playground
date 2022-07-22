using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoinFlip
{
    
    internal class Coin
    {
       public Coin() { }

        private string _up;

        public string Up
        {
            get { return _up; }
            set { _up=value; }
        }
        private string _down;
        public string Down
        {
            get { return _down; }
            set { _down=value; }
        }
        public void set_intial_value()
        {
            Up = Sides.Heads.ToString();
            Down = Sides.Tails.ToString();
            
        }
        public override string ToString()
        {
            return "The Up side is " + Up + " and the Down side is " + Down;
        }
        public void setvalue(string side1,string side2)
        {
            Up = side1;
            Down = side2;

        }
        public void Flip()
        {
            Random rand=new Random();
            int num = rand.Next(0, 2);
            if(num == 0)
            {
            setvalue(Sides.Heads.ToString(), Sides.Tails.ToString());
            }
            else
            {
                setvalue(Sides.Tails.ToString(), Sides.Heads.ToString());
            }
        }
        enum Sides
        {
        Heads,Tails
        }

    }
}
