using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cards
{
    public enum Color
    {
        red = 1, black
    }
    public enum Suit
    {
        heart = 1, Diamond, Spade, club

    }
    public enum Number
    {
        Ace = 1, two, three, four, five, six, seven, eight, Nine
    }
    public  class Card
    {
        public Number Number;
        public Color Color;
        public Suit Suit;
        public string Display()
        {
            int number = (int)Number;
            string suit = Suit.ToString();
            string color = Color.ToString();
            return number + suit + color;
        }
    }
}
