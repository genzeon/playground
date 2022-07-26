using System.ComponentModel.DataAnnotations;

namespace CoinWeb.Models
{
	public class TossingTable
	{
		[Key]
		[Required]
		public int Id { get; set; }
		[Required]
		[StringLength(225)]
		public string Name { get; set; }
		[Required]
		public int FACE_VALUE { get; set; }
		[Required]
		public int TRY { get; set; }	
	}
}
