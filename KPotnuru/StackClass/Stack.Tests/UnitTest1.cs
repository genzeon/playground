using Xunit;
using System;

namespace DataStructure.Tests
{
	public class UnitTest1
	{
		
		[Fact]
		public void Simple()
		{
			DataStructure.Stack<int> stack = new DataStructure.Stack<int>();
			int n = 7;
			stack.Push(n);
			int r = stack.Pop();
			Assert.Equal(n, r);
		}
		[Fact]
		public void SimpleonString()
		{
			DataStructure.Stack<string> stack = new DataStructure.Stack<string>();
			string n = "ChinniKalyan";
			stack.Push(n);
			string r = stack.Pop();
			Assert.Equal(n, r);
		}
		[Fact]
		public void StackUnderflow()
		{
			//Arrange
			DataStructure.Stack<int> stack = new DataStructure.Stack<int>();
			//Act
			Action act = () => stack.Pop();
			//Assert
			Assert.Throws<DataStructure.UnderflowException>(act);
		}
		[Fact]
		public void StackOverflow()
		{
			//Arrange
			int a = 1;
			DataStructure.Stack<int> stack = new DataStructure.Stack<int>();
			//Act
			for (int i = 0; i < 10; i++)
			{
				stack.Push(a);
			}
			Action act = () => stack.Push(a);
			//Assert
			Assert.Throws<DataStructure.OverflowException>(act);
		}

	}
}