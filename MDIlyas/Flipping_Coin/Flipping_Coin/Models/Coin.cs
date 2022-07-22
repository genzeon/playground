namespace Flipping_Coin.Models
{
  
    class Coin
    {
       enum Sides
        {
            Heads, Tails
        }

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

        public void setInitialValues()
        {
            Up = Sides.Heads;
            Down = Sides.Tails;
        }

        public override string ToString()
        {
            return $"Up side : {Up.ToString()} and the Down side : {Down.ToString()}";
        }


        public void Flip()
        {
            Random random = new Random();
            int num = random.Next(2);
            
            if(num == 0)
            {
                Up = Sides.Heads;
                Down = Sides.Tails;
            }
            else
            {
                Up = Sides.Tails;
                Down = Sides.Heads;
            }
        }
       

    }

  
}
