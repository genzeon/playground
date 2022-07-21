namespace TestBlackJackDeck
{
    public enum Color
    {
        red = 1, black
    }
    public enum Suit
    {
        heart = 1, diamond, spade, club,
    }
    public enum Value
    {
        ace = 1, two, three, four, five, six, seven, eight, nine, ten, jack, queen, king
    }
    public class Card
    {
        public Value Value;
        public Suit Suit;
        public Color Color;

        public string Display()
        {

            int value = (int)Value;
            string suit = Suit.ToString();
            string color = Color.ToString();

            return value + suit + color;
        }
    }

    public class Deck
    {
        public List<Card> Cards;


        public void deck()
        {
            Cards = new List<Card>();
            Cards.Add(new Card() { Value = Value.ace, Color = Color.red, Suit = Suit.heart });
            Cards.Add(new Card() { Value = Value.two, Color = Color.red, Suit = Suit.heart });
            Cards.Add(new Card() { Value = Value.three, Color = Color.red, Suit = Suit.heart });
            Cards.Add(new Card() { Value = Value.four, Color = Color.red, Suit = Suit.heart });
            Cards.Add(new Card() { Value = Value.five, Color = Color.red, Suit = Suit.heart });
            Cards.Add(new Card() { Value = Value.six, Color = Color.red, Suit = Suit.heart });
            Cards.Add(new Card() { Value = Value.seven, Color = Color.red, Suit = Suit.heart });
            Cards.Add(new Card() { Value = Value.eight, Color = Color.red, Suit = Suit.heart });
            Cards.Add(new Card() { Value = Value.nine, Color = Color.red, Suit = Suit.heart });
            Cards.Add(new Card() { Value = Value.ten, Color = Color.red, Suit = Suit.heart });
            Cards.Add(new Card() { Value = Value.king, Color = Color.red, Suit = Suit.heart });
            Cards.Add(new Card() { Value = Value.queen, Color = Color.red, Suit = Suit.heart });
            Cards.Add(new Card() { Value = Value.jack, Color = Color.red, Suit = Suit.heart });
         
            
          





            //for (int suit = 1; suit <= 4; suit++)
            //{
            //    for (int value = 1; value <= 13; value++)
            //    {
            //        Card card = new Card();
            //        card.Value = (Value)value;
            //        card.Suit = (Suit)suit;
            //        if (suit == 1 || suit == 2)
            //        {
            //            card.Color = (Color)1;
            //        }
            //        else if (suit == 3 || suit == 4)
            //        {
            //            card.Color = (Color)2;
            //        }

            //        Cards.Add(card);
            //    }

            //}

        }
        public void DeckShuffle()
        {
            Random rnd = new Random();

            for (int i = 1; i < 52; i++)
            {
                int num = rnd.Next(1, 52);
                var temp = Cards[i];
                Cards[i] = Cards[num];
                Cards[num] = temp;
            }
        }
    }
    public class UnitTest1
    {
        [Fact]
        public void CardClassTest()
        {
            //Arrange
            Card card = new Card();
            card.Value = Value.ace;
            card.Suit = Suit.club;
            card.Color = Color.black;
            //Act
            //Assert   
            Assert.Equal(Value.ace, card.Value);
            Assert.Equal(Suit.club, card.Suit);
            Assert.Equal(Color.black, card.Color);
        }
        [Fact]
        public void DisplayMethodTest()
        {
            //Arrange
            Card card = new Card();
            card.Value = Value.ace;
            card.Suit = Suit.club;
            card.Color = Color.black;
            //Act
            var q = card.Display();
            //Assert
            q.Equals("1clubblack");
        }

        [Fact]
        public void DeckMethodtest()
        {
            //Arrange
            Deck deck = new Deck();
            //Act
            deck.deck();

            //Assert
            int noofcards = deck.Cards.Count();
            Assert.Equal(52, noofcards);
            var A = deck.Cards;
            int count = 0;
            for (int i = 0; i < deck.Cards.Count(); i++)
            {


                for (int j = 0; j < deck.Cards.Count(); j++)
                {
                    if (i == j)
                    {
                        continue;
                    }


                    if (A[i].Value == A[j].Value)

                    {
                        count++;
                        break;
                    }

                }

            }

            Assert.Equal(52, count);


        }


        [Fact]
        public void DeckMethodtestduplicates()
        {
            //Arrange
            Deck deck = new Deck();
            //Act
            deck.deck();

            //Assert

            var A = deck.Cards;
            int count = 0;
            for (int i = 0; i < A.Count; i++)
            {

                for (int j = i; j < A.Count; j++)
                {
                    if (i == j )
                    {
                        continue;
                    }
                  
                    else if (A[i].Value == A[j].Value & A[i].Suit == A[j].Suit & A[i].Color == A[j].Color)
                    {
                        count++;
                    }
                   
                }



            }

            Assert.Equal(2,count);

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