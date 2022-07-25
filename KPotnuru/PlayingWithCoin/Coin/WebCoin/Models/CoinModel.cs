using System.ComponentModel.DataAnnotations;

namespace WebCoin.Models
{
	public class CoinModel
	{
		[Key]
		[Required]
		public int No_Of_Toss { get; set; }
		[Required]
		public bool Occurence { get; set; }
	}
}
