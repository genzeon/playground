using System.ComponentModel.DataAnnotations;
namespace WebAppForCoin.Models
{
	public class CoinModel
	{
		[Key]
		[Required]
		public int Toss { get; set; }
		[Required]
		[Display(Name ="Occured Output")]
		public string OccuredOutput { get; set; }
	}
}
