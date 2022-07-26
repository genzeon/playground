using CoinWeb.Models;

namespace CoinWeb.Repositary
{
	public interface ICoinRepositary
	{
		IEnumerable<Occurence> GetAll();
		void Add(Occurence occurence);
		void Save();
	}
}
