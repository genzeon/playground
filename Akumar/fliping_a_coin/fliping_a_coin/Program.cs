using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coin
{

    enum flips
    {
        Heads = 1, Tails
    }
    internal class Class1
    {
        public flips turn;
        public flips Up
        {

            get
            {
                return flips.Heads;
            }
            set
            {
                turn = flips.Heads;
            }
        }
        public flips Down
        {

            get
            {
                return flips.Tails;
            }
            set
            {
                turn = flips.Tails;
            }
        }

        public Class1(flips _up, flips _down)
        {
            this.Up = _up;
            this.Down = _down;

        }
        public override string ToString()
        {
            string str;
            Random random = new Random();
            int num = random.Next(0, 2);
            if (num == 0)
            {
                str = $"up=" + Up;
                return str;
            }
            else
            {
                str = $"down=" + Down;
                return str;
            }
        }

        //public void flip()
        //{

        //    Random random = new Random();
        //    int num = random.Next(0, 2);
        //    if (num == 0)
        //    {
        //        Up = flips.Heads;
        //        Down = flips.Tails;
        //    }
        //    else
        //    {
        //        Up = flips.Heads;
        //        Down = flips.Tails;
        //    }
        //}

        static void Main(string[] args)
        {
            flips var1 = flips.Heads;
            flips var2 = flips.Tails;
            Class1 con = new Class1(var1, var2);
            
            Console.WriteLine(con.ToString());
            Console.WriteLine(con.ToString());
            Console.WriteLine(con.ToString());
            Console.WriteLine(con.ToString());

            Console.ReadLine();
           


        }
    }
}