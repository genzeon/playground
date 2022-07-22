using TossingOfACoin.Controllers;

namespace TossingOfACoin.Models
{
    public class Fliping
    {
        public sides upside;
        public sides downside;

        public sides Upside
        {
            get { return upside; }
            set { upside = value; }
        }
        public sides Downside
        {
            get { return downside; }
            set { downside = value; }
        }
        
        public  Fliping()
        {
            upside = sides.Heads;
            downside = sides.Tails;
        }
       
      
    }
}
