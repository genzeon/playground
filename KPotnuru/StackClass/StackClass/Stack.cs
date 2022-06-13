namespace DataStructure
{
	public class Stack<T> 
	{
	    T[] Store;
		int Position = 0;
		int size = 10;
		public Stack()
		{
			Store = new T[size];
		}
		public void Push(T value)
		{
			if (Position >= size)
				throw new OverflowException();
			Store[Position] = value;
			Position++;
		}
		public T Pop()
		{
			if (Position <= 0)
				throw new UnderflowException();
			T value = Store[Position - 1];
			Position--;
			return value;

		}
		
	}
}