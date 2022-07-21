using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;





namespace PlayingWithCoin
{
	enum sidesofcoin
	{
		Heads, Tails
	}
	class Coin
	{
		string FacingUpside;
		string FacingDownside;
		public Coin(string _FacingUpside, string _Facingdownside)
		{
			FacingDownside = _Facingdownside;
			FacingUpside = _FacingUpside;
		}
		void filp()
		{
			Random rand = new Random();
			int num = rand.Next(2);
			sidesofcoin side = (sidesofcoin)num;
			FacingUpside = side.ToString();
			if (num != 0)
			{
				FacingDownside = sidesofcoin.Heads.ToString();
			}
			else
			{
				FacingDownside = sidesofcoin.Tails.ToString();
			}
		}
		public override string ToString()
		{
			return $"Upside: {FacingUpside} \nDownside: {FacingDownside}";
		}
		static void Main(string[] args)
		{
			Coin coin = new Coin("Head", "Tail");
			Console.WriteLine(coin.ToString());
			coin.filp();
			Console.WriteLine(coin.ToString());
			coin.filp();
			Console.WriteLine(coin.ToString());
			coin.filp();
			Console.WriteLine(coin.ToString());
			coin.filp();
			Console.WriteLine(coin.ToString());
			coin.filp();
			Console.WriteLine(coin.ToString());
			coin.filp();
			Console.WriteLine(coin.ToString());
			Console.ReadLine();
		}
	}
}

