using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoinFlip
{
     class Fliping
    {
        enum Sides
        { 
            Head,Tails
        
        }

        public string Upside;
        public string Bottom;

        public Fliping(string _Upside,string _Bottom)
        { 
          Upside = _Upside;
            Bottom = _Bottom;
        
        }


        public void Display()
        { 
        
        }


        public  void coins()
        {
            string z;
            


            Random r = new Random();

            int x = r.Next(0, 2);

            Sides Head = (Sides)x;
            z = Head.ToString();
            Console.WriteLine("The Upper Side "+Head.ToString());
            if (x==0)
            {
               
                Console.WriteLine("The Bottom Side Is Tail");
            }
            else
            {
               
                Console.WriteLine("The Bottom side Head ");
            }
            Console.ReadLine();

            
        }
    }
}
