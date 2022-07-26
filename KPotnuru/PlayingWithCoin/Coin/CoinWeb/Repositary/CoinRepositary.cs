using CoinWeb.Data;
using CoinWeb.Models;

namespace CoinWeb.Repositary
{
	public class CoinRepositary : ICoinRepositary
	{
		public  DataContext Context;
		public CoinRepositary(DataContext _Context)
		{
			Context = _Context;
		}
		public void Add(Occurence occurence)
		{
			Context.TossResults.Add(occurence);
		}

		public IEnumerable<Occurence> GetAll()
		{
			return Context.TossResults;
		}

		public void Save()
		{
			Context.SaveChanges();
		}
	}
}
