namespace CoinClass
{

    public enum CoinFace
    {
        heads, tails
    }

    public  class Coin
    {
       
        private string _name;
        private int _toss;
        private CoinFace _up;
        private CoinFace _down;
        private int _headcount;
        private int _tailcount;

       
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public int Toss
        {
            get { return _toss; }
            set { _toss = value; }
        }
        public CoinFace Up
        {
            get { return _up; }
            set { _up = value; }


        }
        public CoinFace Down
        {

            get { return _down; }
            set { _down = value; }
        }

        public int Headcount
        {
            get { return _headcount; }
            set { _headcount = value; }
        }
        public int Tailcount
        {
            get { return _tailcount; }
            set { _tailcount = value; }
        }
       

        public Coin()
        {
            Up = CoinFace.heads;
            Down = CoinFace.tails;
            
        }
        public override string ToString()
        {
            //string str = $"up= {this.Up} Down={this.Down}";
            string str = this.Up.ToString();
            return str;
        }

        public void flip()
        {
            Random random = new Random();
            int num = random.Next(2);

            if (num == 0)
            {
                Up = CoinFace.heads;
                Headcount++;
                Down = CoinFace.tails;

            }
            else
            {

                Up = CoinFace.tails;
                Tailcount++;
                Down = CoinFace.heads;
            }

            Toss++;

        }

    }


}