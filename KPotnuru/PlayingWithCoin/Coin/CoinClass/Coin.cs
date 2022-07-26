using System;
namespace CoinClass
{
	public enum sidesofcoin
	{
		Heads, Tails
	}
	public class Coin
	{
		public sidesofcoin FacingUpside;
		public sidesofcoin FacingDownside;
		public string CoinName;
		public Coin()
		{
			FacingDownside = sidesofcoin.Heads;
			FacingUpside = sidesofcoin.Tails;
		}
		public void filp()
		{
			Random rand = new Random();
			int num = rand.Next(2);
			Console.WriteLine(num);
			if (num != 0)
			{
				FacingDownside = sidesofcoin.Heads;
				FacingUpside = sidesofcoin.Tails;
			}
			else
			{
				FacingDownside = sidesofcoin.Tails;
				FacingUpside = sidesofcoin.Heads;
			}
		}
		public new string ToString()
		{
			return $"Upside: {FacingUpside} \nDownside: {FacingDownside}";
		}
	}
}