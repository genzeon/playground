using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    public enum Color
    {
        red = 1, black
    }
    public enum Suit
    {
        heart = 1, diamond,spade, club, 
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
        public string Image;

        
    }
}
   
  