using CoinClass;
using Xunit;
namespace CoinTest
{
	public class UnitTest1
	{
		[Fact]
		public void IsFliping()
		{
			//Arrange
			bool ActualValue = false;
			bool ExpectedValue = true;
			Coin coin = new Coin();
			//Act
			coin.filp();
			if (coin.FacingUpside == sidesofcoin.Heads || coin.FacingUpside == sidesofcoin.Tails)
				ActualValue = true;
			//Assert
			Assert.Equal(ExpectedValue, ActualValue);
		}
		[Fact]
		public void IsCoinRightorWrong()
		{
			//Arrange
			int HeadsOccur=0;
			int TailsOccur=0;
			bool ExpectedValue = true;
			bool OccuredValue=false;
			Coin coin = new Coin();
			//Act
			for (int i = 0; i <= 50; i++)
			{
				coin.filp();
				if (coin.FacingUpside == sidesofcoin.Heads)
					HeadsOccur++;
				else
					TailsOccur++;
			}
			//Assert
			Assert.Equal(ExpectedValue, OccuredValue); 
		}
	}
}