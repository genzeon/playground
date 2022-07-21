using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{


 
    public class Deck
    {
        public Stack<Card> Cards;
        public void DeckSize(int Numberofplayers)
        {
            Cards = new Stack<Card>();
            for (int p = 0; p <= Numberofplayers ; p++)
            {
                for (int suit = 1; suit <= 4; suit++)
                {
                    for (int value = 1; value <= 13; value++)
                    {
                        Card card = new Card();
                        card.Value = (Value)value;
                        card.Suit = (Suit)suit;
                        if (suit ==1 ||suit ==2)
                        {
                            card.Color = (Color)1;
                        }
                        else if (suit ==3 ||suit ==4)
                        {
                            card.Color = (Color)2;
                        }

                        card.Image = card.Value.ToString() + card.Suit + card.Color;
                        Cards.Push(card);
                    }
                }
            }
        }
        public void DeckShuffle()
        {
            Random rnd = new Random();
            Card[] array = Cards.ToArray();
            Cards.Clear();
            for (int i = 0; i < array.Count(); i++)
            {
                int num = rnd.Next(1, array.Length);
                var temp = array[i];
                array[i] = array[num];
                array[num] = temp;
                Cards.Push(temp);
            }
        }

     
        public Stack<Card> GetAll()
        {

            return Cards;
        }


    }
}
