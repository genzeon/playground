using System.ComponentModel.DataAnnotations;

namespace CoinWeb.Models
{
	public class Occurence
	{
		[Key]
		[Required]
		public int No_Of_Toss { get; set; }
		[Required]
		public string Result { get; set; }
	}
}
