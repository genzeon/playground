namespace FlippingofCoin.Models
{
    public enum sides
    {
        Heads,Tails
    }
    public class Flipping
    {
        public int toss;
        public string _name;

        public sides upside;
        public sides downside;
        public int _toss
        {
            get { return toss; }
            set { toss = value; }
        }
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
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
        public void Stimulation()
        {
            Upside = sides.Heads;
            Downside = sides.Tails;
        }
        public override string ToString()
        {
            string str = $"Upside : {Upside} , Downside : {Downside}";
            return str;
        }
        public void Flip()
        {


            int num;
            Random random = new Random();

            num = random.Next(2);
            if (num == 0)
            {
                Upside = sides.Heads;
                Downside = sides.Tails;
            }
            else
            {
                Upside = sides.Tails;
                Downside = sides.Heads;
            }

            _toss++;

        }
    }
}
