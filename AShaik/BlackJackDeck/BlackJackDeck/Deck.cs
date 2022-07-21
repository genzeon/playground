using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJackDeck
{
    public class Deck
    {
        public List<Card> Cards;

        public void deck()
        {
            Cards = new List<Card>();

            for (int suit = 1; suit <= 4; suit++)
            {
                for (int value = 1; value <= 13; value++)
                {
                    Card card = new Card();
                    card.Value = (Value)value;
                    card.Suit = (Suit)suit;
                    if (suit == 1 || suit == 2)
                    {
                        card.Color = (Color)1;
                    }
                    else if (suit == 3 || suit == 4)
                    {
                        card.Color = (Color)2;
                    }

                    Cards.Add(card);
                }

            }

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
}
