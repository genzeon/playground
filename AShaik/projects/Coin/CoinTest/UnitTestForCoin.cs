using CoinStimulates.Models;

namespace CoinTest
{
    public class UnitTestForCoin
    {
        [Fact]
        public void FlipTest()
        {
            //Arrange
            coin c = new coin();

            //Act   



            var  s = c.flip();
            

            //Assert
            Assert.Equal($"Up side={c.Up} DownSide = {c.Down}",s);



        }
    }
}