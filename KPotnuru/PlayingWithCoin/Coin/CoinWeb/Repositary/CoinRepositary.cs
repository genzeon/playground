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
		public void Add(TossingTable table)
		{
			Context.TossingTable.Add(table);
		}

		public IEnumerable<TossingTable> GetAll(TossingTable table)
		{
			return Context.TossingTable.Where(a=>a.Name==table.Name).ToList();
		}

		public void Save()
		{
			Context.SaveChanges();
		}
	}
}
