using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoinFlip
{
    public class coin
    {
        public enum face
        {
            Heads, Tails
        }
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

        public coin()
        {
            upside = face.Heads;
            downside = face.Tails;
        }

        public override string ToString()
        {
            return $"Up{upside},Down{downside}";
        }

        public void Flip()
        {
            int  num;

            Random r=new Random();

            num = r.Next(2);
            if (num == 0)
            {
                upside = face.Heads;
                downside = face.Tails;
            }
            else
            {
                upside = face.Tails;
                downside = face.Heads;
                
            
            }
        
        }
        


      
    
    
    
    
    }
}
