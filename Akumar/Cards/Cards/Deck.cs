using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cards
{
    public class Deck
    {
        public List<Card> Cards ;
        public void deck()
        {
            Cards = new List<Card>();
            for (int suit = 1; suit <= 4; suit++)
            {
                for (int number =1; number <=13; number++)
                {
                    Card cards = new Card();  
                    cards.Number = (Number)number;
                    cards.Suit = (Suit)suit;
                    if (suit == 1 || suit == 2)
                    {
                        cards.Color = (Color)1;
                    }
                    if (suit ==3 || suit == 4)
                    {
                        cards.Color = (Color)2;
                    }
                    Cards.Add(cards);
                }
            }
        }
        public void DeckShuffle()
        {
            Random rand = new Random();
            for(int i = 1; i<52;i++)
            {
                int num = rand.Next(1, 52);
                var temp = Cards[i];
                Cards[i] = Cards[num];
                Cards[num] = temp;
            }
        }
    }
}
