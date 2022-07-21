using Xunit;
using DataStructure;
namespace AnotherTest
{
	public class TestStack
	{
		[Fact]
		public void SimplePop()
		{
			//Arrange
			Stack stack = new Stack();
			int n = 8;
			//Act
			stack.Push(n);
			//Assert
			Assert.Equal(n, stack.Pop());
		}
	}
}