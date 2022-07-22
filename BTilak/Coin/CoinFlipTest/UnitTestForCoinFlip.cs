using Xunit;
namespace CoinFlipTest
{
    public class UnitTestForCoinFlip
    {
        [Fact]
        public void FlippingTest()
        {
            //Arrange
            Coins.Coin coin = new Coins.Coin();
            //Act
            var result = coin.Flip();
            //Assert
            for(int i=1; i<=100; i++)
            {
                Assert.Equal($"Up side = {coin.Up} and Down side  = {coin.Down}", result);
            } 
        }
    }
}