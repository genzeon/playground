using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoinFlip
{
    enum Sides
    {
        Heads, Tails
    }
    class coin
    {
     

         public string upside
        {
            get; set;
            //get {return Sides.Heads; }
            //set {face = Sides.Heads; }
        }
        public string downside
        {
            get; set;
            //get { return Sides.Tails; }
            //set { face = Sides.Tails; }
        }
        public coin(string _upside, string _downside)
        {
            upside = _upside;
            downside = _downside;
            Flip();
        }

        public override string ToString()
        {
            string Str = $"Upside : " + this.upside + "," + "Downside" +this.downside;
            return Str;
        }
        public void Flip()
        {
            string A;
           
            Random R = new Random();

            int Y = R.Next(0, 2);
            Sides Heads = (Sides)Y;
            A = Heads.ToString();
            

            if (Y == 0)
            {
                
                //Console.WriteLine("Heads");
               Console.WriteLine("The top of the coin is heads and the bottom of the coin is tails.");

            }
            else
            {

               // Console.WriteLine("Tails");
                Console.WriteLine("The top of the coin is Tails and the bottom of the coin is heads.");

            }
            Console.ReadLine();
        }
       
    }
}
