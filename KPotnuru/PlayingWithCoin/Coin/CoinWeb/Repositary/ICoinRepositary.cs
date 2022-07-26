using CoinWeb.Models;

namespace CoinWeb.Repositary
{
	public interface ICoinRepositary
	{
		IEnumerable<TossingTable> GetAll(TossingTable table);
		void Add(TossingTable table);
		void Save();
	}
}
