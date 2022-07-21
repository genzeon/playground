using Xunit;
using System;
using System.Collections.Generic;

namespace DataStructure.Tests
{
    public enum Suit
    {
        heart = 1, Spades, Clubs ,Diamonds
    }
    public enum Value
    {
        ace = 1, two, three, four, five, six, seven, eight, nine, ten, jack, queen, king
    }
    public class Card
    {
        public Value Value;
        public Suit Suit;
    }
    public class UnitTest1
    {
        [Fact]
        public void PushPoponInt()
        {
            //Arrange
            int n = 7;
            DataStructure.Stack<int> stack = new DataStructure.Stack<int>(416);
            //Act
            stack.Push(n);
            int r = stack.Pop();
            //Assert
            Assert.Equal(n, r);
        }
        [Fact]
        public void PushPoponString()
        {
            //Arrange
            string n = "aakheel";
            DataStructure.Stack<string> stack = new DataStructure.Stack<string>(416);
            //Act
            stack.Push(n);
            string r = stack.Pop();
            //Assert
            Assert.Equal(n, r);
        }
        [Fact]
        public void StackUnderflow()
        {
            //Arrange
            DataStructure.Stack<int> stack = new DataStructure.Stack<int>(416);
            //Act
            Action act = () => stack.Pop();
            //Assert
            Assert.Throws<DataStructure.UnderflowException>(act);
        }
        [Fact]
        public void StackOverflowonInt()
        {
            //Arrange
            int value = 1;
            DataStructure.Stack<int> stack = new DataStructure.Stack<int>(416);
            //Act
            for (int i = 0; i < 416; i++)
            {
                stack.Push(value);
            }
            Action act = () => stack.Push(value);
            //Assert
            Assert.Throws<DataStructure.OverflowException>(act);

        }
        [Fact]
        public void StackOverflowonString()
        {
            //Arrange
            string s = "aakheel";
            DataStructure.Stack<string> stack = new DataStructure.Stack<string>(416);
            //Act
            for (int i = 0; i < 416; i++)
            {
                stack.Push(s);
            }
            Action act = () => stack.Push(s);
            //Assert
            Assert.Throws<DataStructure.OverflowException>(act);
        }

        [Fact]
        public void StackOverflowonClass()
        {
            //Arrange
            Card card = new Card();
            DataStructure.Stack<Card> stack = new DataStructure.Stack<Card>(416);
            card.Value = Value.ace;
            card.Suit = Suit.heart;
            //Act
            stack.Push(card);
            var r = stack.Pop();
            //Assert
            Assert.Equal(card, r);
        }
       // [Fact]
        [Theory]
        [InlineData(1)]
        [InlineData(2)]
        [InlineData(3)]
        [InlineData(4)]
        [InlineData(5)]
        [InlineData(6)]
        [InlineData(7)]
        public void DeckSizecustomstack(int player)
        {
            //Arrange
            int noofcards=0;
            if (player == 1)
            {
                 noofcards = 104;
            }
            else if (player == 2)
            {
                 noofcards = 156;
            }
            else if (player == 3)
            {
                 noofcards = 208;
            }
            else if (player == 4)
            {
                 noofcards = 260;
            }
            else if (player == 5)
            {
                 noofcards = 312;
            }
            else if (player == 6)
            {
                 noofcards = 364;
            }
            else if (player == 7)
            {
                noofcards = 416;
            }
           
            DataStructure.Stack<Card> stack = new DataStructure.Stack<Card>(noofcards);
            
            //Act
            for (int i = 1; i <= player; i++)
            {
                for (int suit = 1; suit <= 4; suit++)
                {
                    for (int value = 1; value <= 13; value++)
                    {
                        Card card = new Card();
                        card.Value = (Value)value;
                        card.Suit = (Suit)suit;
                           stack.Push(card);
                    }
                }
            }
            //Assert
            int count = stack.Count();
           Assert.Equal(noofcards, count);   
        }


        //[Fact]

        [Theory]
        [InlineData(1)]
     

        public void DeckShufflecustomstack(int player)
        {
            //Arrange
           
            DataStructure.Stack<Card> stackbeforeswap = new DataStructure.Stack<Card>(player);
            DataStructure.Stack<Card> stackafterswap = new DataStructure.Stack<Card>(player);

            for (int i = 0; i < 1; i++)
            {
                Card card = new Card();
                card.Value = Value.ace;
                card.Suit = Suit.heart;
                card.Value = Value.two;
                card.Suit = Suit.heart;
                stackafterswap.Push(card);
               
            }


            

            Random rnd = new Random();

            //Act
            for (int i = 1; i < stackafterswap.Count(); i++)
            {
                int num = rnd.Next(1, stackafterswap.Count());
                Card temp = stackafterswap.Store[i]; // value at i position
                stackafterswap.Store[i] = stackafterswap.Store[num];  //  change i place with random number
                stackafterswap.Store[num] = temp; //    at random placing stored temp value
            }
            //Assert

            for (int i = 1; i < stackafterswap.Count(); i++)
            {

                var tempbeforeswap = stackbeforeswap.Store[i];
                var tempafterswap = stackafterswap.Store[i];


                Assert.NotEqual(tempbeforeswap, tempafterswap);

            }
        }


        [Theory]
        [InlineData(1)]
        [InlineData(2)]
        [InlineData(3)]
        [InlineData(4)]
        [InlineData(5)]
        [InlineData(6)]
        [InlineData(7)]
        public void DeckSizelist(int player)
        {
            //Arrange
            int noofcards = 0;
            if (player == 1)
            {
                noofcards = 104;
            }
            else if (player == 2)
            {
                noofcards = 156;
            }
            else if (player == 3)
            {
                noofcards = 208;
            }
            else if (player == 4)
            {
                noofcards = 260;
            }
            else if (player == 5)
            {
                noofcards = 312;
            }
            else if (player == 6)
            {
                noofcards = 364;
            }
            else if (player == 7)
            {
                noofcards = 416;
            }
            List<Card> list = new List<Card>();
            //Act
            for (int i = 0; i <= player; i++)
            {
                for (int suit = 1; suit <= 4; suit++)
                {
                    for (int value = 1; value <= 13; value++)
                    {
                        Card card = new Card();
                        card.Value = (Value)value;
                        card.Suit = (Suit)suit;
                        list.Add(card);
                    }
                }
            }
            //Assert
            int count = list.Count;
            Assert.Equal(noofcards, count);

        }
        [Theory]
        [InlineData(1)]
        public void DeckShufflelist(int player)
        {
            //Arrange
            List<Card> listbeforeswap = new List<Card>();
            List<Card> listafterswap = new List<Card>();
            for (int i = 0; i < 1; i++)
            {
                Card card = new Card();
                card.Value = Value.ace;
                card.Suit = Suit.heart;
                card.Value = Value.two;
                card.Suit = Suit.heart;
                listbeforeswap.Add(card);
                listafterswap.Add(card);
                
            }
            Card[] array = listafterswap.ToArray();
            listafterswap.Clear();
            Random rnd = new Random();

            //Act

          
            for (int i = 1; i < array.Length; i++)
            {

                int num = rnd.Next(1, listafterswap.Count);
                Card temp = array[i]; // value at i position
                array[i] = array[num];  //  change i place with random number
                array[num] = temp; //    at random placing stored temp value
                listafterswap.Add(array[i]); //add back to list again from array
            }
            //Assert

            for (int i = 1; i < listafterswap.Count; i++)
            {

                var tempbeforeswap = listbeforeswap[i];
                var tempafterswap = listafterswap[i];
                Assert.NotEqual(tempbeforeswap, tempafterswap);

            }

        }
    }
}