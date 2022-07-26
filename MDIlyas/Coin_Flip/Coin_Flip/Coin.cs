using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coin_Flip
{
    public interface ICoinFlip
    {
        string Up { get; set; }
        string Down { get; set; }
        void set_initial_Sides();
        void Flip();

        int Count() { return 0; }

    }
    public class Coin : ICoinFlip
    {
        public Coin() { }


        private string _up;
        public string Up
        {
            get { return _up; }
            set { _up = value; }
        }
        private string _down;
        public string Down
        {
            get { return _down; }
            set { _down = value; }
        }

        public void set_initial_Sides()
        {
            Up = Sides.Heads.ToString();
            Down = Sides.Tails.ToString();  
        }

        public void SetVal(string side1, string side2)
        {
            Up = side1;
            Down = side2;
        }

        public void Flip()
        {
            Random rand = new Random();
            int rnd_num = rand.Next(0,2);
            if(rnd_num == 0)
            {
                SetVal(Sides.Heads.ToString(),Sides.Tails.ToString());
            }
            else
            {
                SetVal(Sides.Tails.ToString(), Sides.Heads.ToString());
            }
        }

        //public override string ToString()
        //{
        //    return "The Up side is " + Up + " and the Down side is " + Down;
        //}

        int count = 0;

        public int Count()
        {
            return count++;
        }

        public enum Sides
        {
            Heads,Tails
        }
    }
}
