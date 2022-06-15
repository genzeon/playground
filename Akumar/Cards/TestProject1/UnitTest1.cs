using Xunit;
using Cards;
using System.Linq;

namespace TestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {   
            //Arrange
            Card cards = new Card();
            cards.Number = Number.Ace;
            cards.Suit = Suit.club;
            cards.Color = Color.black;
            //Act 
            var q = cards.Display();
            // Assert
            q.Equals("1clubblack");
        }
        [Fact]
        public void Test2()
        {
            //Arrange
            Deck deck = new Deck();
            //Arrange
            deck.deck();
            //Assert
            int NoCards = deck.Cards.Count();
            Assert.Equal(52, NoCards);

                
                
                }
        [Fact]
        public void DeckshuffleMethodTest()
        {
            //Arrange
            Deck instancedeck = new Deck();
            //Act
            instancedeck.deck();
            var beforeshuffle = instancedeck.Cards;
            instancedeck.DeckShuffle();
            var aftershuffle = instancedeck.Cards;
            //Assert
            Assert.Equal(beforeshuffle, aftershuffle);
        }
    }
}