using FlipingOfACoin.Controllers;

namespace FlipingOfACoin.Models
{
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

        public Coin()
        {
            Upside = face.Heads;
            Downside = face.Tails;
        }


    }

}
