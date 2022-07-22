using FlippingCoins.Controllers;

namespace FlippingCoins.Models
{
    public class Coin
    {
   
        face _upside;
        face _downside;

        public face upside
        {
            get { return _upside; }
            set { _upside = value; }
        }

        public face downside
        {
            get { return _downside; }
            set { _downside = value; }
        }

        public Coin()
        {
            upside = face.Heads;
            downside = face.Tails;
        }

        
    }
}
