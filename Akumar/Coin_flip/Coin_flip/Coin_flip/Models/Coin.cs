using Coin_flip.Controllers;

namespace Coin_flip.Models
{
    public enum Face
    {
        Heads, tails
    }

    public class Coin
    {
        public void set_Intial_Stage()
        {
            Up = Face.Heads;
            Down = Face.tails;
        }
      
        Face _up;
        Face _down;

        public Face Up
        {
            get { return _up; }
            set { _up = value; }
        }
        public Face Down
        {
            get { return _down; }
            set { _down = value; }
        }
        public void flip()
        {


            Random random = new Random();
            int num = random.Next(0, 2);
            if (num == 0)
            {
                Up = Face.Heads;
                Down = Face.tails;


            }
            else
            {
                Up = Face.tails;
                Down = Face.Heads;
            }

        }
        int count = 0;
        int count2 = 0;
        public override string ToString()
        {



            string str = "up = " + Up + "," + "down=" + Down;


            if (Up == Face.Heads)
            {
                count++;
            }
            else
            {
                count2++;
            }
            return str;

        }


        static void Main(string[] args)
        {
            Coin Con = new Coin();
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(Con.ToString());
                Con.flip();
            }
            Console.WriteLine(Con.count + " Times Heads were occured");
            Console.WriteLine(Con.count2 + " Times Tails were occured");


        }
    }
}

    

