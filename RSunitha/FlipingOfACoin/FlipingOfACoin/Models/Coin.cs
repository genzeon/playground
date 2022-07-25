using FlipingOfACoin.Controllers;

namespace FlipingOfACoin.Models
{
    public enum face
    {
        Heads, Tails
    }
    public class Coin
    {

        face _upside;
        face _downside;

        public face Upside
        {
            get { return _upside; }
            set { _upside = value; }
        }

        public face Downside
        {
            get { return _downside; }
            set { _downside = value; }
        }

        public void IntialSides()
        {
            Upside = face.Heads;
            Downside = face.Tails;
        }
        public override string ToString()
        {
            return $"The UpSide of the Coin is {Upside.ToString()} and " +
                $"The DownSide of the Coin is{Downside.ToString()}";
        }

        public void Flip()
        {


            int num;
            Random random = new Random();

            num = random.Next(2);
            if (num == 0)
            {
                Upside = face.Heads;
                Downside = face.Tails;
            }
            else
            {
               Upside = face.Tails;
               Downside = face.Heads;
            }

          

        }
    }

}
