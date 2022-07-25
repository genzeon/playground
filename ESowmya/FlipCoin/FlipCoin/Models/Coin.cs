namespace FlipCoin.Models
{
    public class Coin
    {
        public Coin() { }

        private Enum _up;
        public Enum Up
        {
            get { return _up; }
            set { _up = value; }
        }
        private Enum _down;
        public Enum Down
        {
            get { return _down; }
            set { _down = value; }

        }

        public  void set_intial_value()
        {
            Up = Sides.Heads;
            Down = Sides.Tails;

        }
        public override string ToString()
        {
            return "The UpSide is: " + Up.ToString() + " and the Down side is :" + Down.ToString();
        }
      

        public void Flip()
        {
            Random rdm=new Random();
            int num = rdm.Next(2);
            if (num == 0)
            {
                Up=Sides.Heads;
                Down=Sides.Tails;
            }
            else
            {
                Up = Sides.Tails;
                Down = Sides.Heads;
            }
        }



        enum Sides
        {
            Heads,Tails
        }
    }
}
