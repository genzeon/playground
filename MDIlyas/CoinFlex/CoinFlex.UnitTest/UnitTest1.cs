namespace CoinFlex.UnitTest
{
    public class CoinTests
    {
        [Fact]
        public void Flip_Side_Heads()
        {
            // Arrange

            var coinFlex = new Coin();

            // Act

            var result = coinFlex.Flip();

            // Assert

            Assert.Equal("Heads", result);

        }
    }
}