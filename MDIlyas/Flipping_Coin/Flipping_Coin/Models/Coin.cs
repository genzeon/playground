namespace Flipping_Coin.Models
{
  
    class Coin
    {
       enum Sides
        {
            Heads, Tails
        }

        private Enum _up;
        public Enum facing_up
        {
            get { return _up; }
            set { _up = value; }
        }

        private Enum _down;
        public Enum facing_down
        {
            get { return _down; }
            set { _down = value; }
        }

        public void setInitialValues()
        {
            facing_up = Sides.Heads;
            facing_down = Sides.Tails;
        }

        public override string ToString()
        {
            return $"Up side : {facing_up.ToString()} and the Down side : {facing_down.ToString()}";
        }


        public void Flip()
        {
            Random random = new Random();
            int num = random.Next(2);
            
            if(num == 0)
            {
                facing_up = Sides.Heads;
                facing_down = Sides.Tails;
            }
            else
            {
                facing_up = Sides.Tails;
                facing_down = Sides.Heads;
            }
        }
       

    }

  
}
