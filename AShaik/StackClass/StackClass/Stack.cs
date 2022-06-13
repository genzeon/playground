namespace DataStructure
{
	public class Stack<T> 
	{
	   public T[] Store;
		int Position = 0;
		 int size = 0 ;
		public Stack(int size )
		{
			this.size = size;
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

		public int Count()
		{
			return Store.Length;
		}

	}
}