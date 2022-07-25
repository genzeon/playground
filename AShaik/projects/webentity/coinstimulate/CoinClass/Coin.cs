

namespace coinstimulate.Models
{


    public enum Coinface
    {
        heads, tails
    }

    public sealed class coin
    {

        private int _toss;
        private Coinface _up;
        private Coinface _down;
        private int _headcount;
        private int _tailcount;
        private static coin _instance;



        public int Toss
        {
            get
            {
                return _toss;


            }

            set
            {
                _toss = value;
            }
        }
        public Coinface Up
        {
            get { return _up; }
            set { _up = value; }


        }
        public Coinface Down
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
        public static coin Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new coin();
                }


                return _instance;
            }

        }

        private coin()
        {
            Up = Coinface.heads;
            Down = Coinface.tails;
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
                Up = Coinface.heads;
                Headcount++;
                Down = Coinface.tails;

            }
            else
            {

                Up = Coinface.tails;
                Tailcount++;
                Down = Coinface.heads;
            }

            Toss++;

        }

    }

}
