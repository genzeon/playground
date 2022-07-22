using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//namespace Coin
//{
//    internal class Coin
//    {
//    }
//}


namespace CoinStimulates.Models
{


    public enum Coinface
    {
        heads = 1, tails
    }

    public class coin
    {

        Coinface _Up;
        Coinface _Down;
      

        public Coinface Up
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
        public Coinface Down
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

        public coin()
        {
            Up = Coinface.heads;
            Down = Coinface.tails;


        }
        public override string ToString()
        {
            string str = $"up={this.Up}  Down= {this.Down}";
            return str;
            //up=heads down=tails
        }

        public string flip()
        {
            

            Random random = new Random();
            int num = random.Next(2);
           
            if (num == 0)
            {
                Up = Coinface.heads;
                Down = Coinface.tails;
            }
            else
            {
               
                Up = Coinface.tails;
                Down = Coinface.heads;
            }
            return ToString();
        }

       
    }

}
