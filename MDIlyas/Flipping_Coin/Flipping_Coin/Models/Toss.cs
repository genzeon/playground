using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Flipping_Coin.Models
{
    public class Toss
    {

        [Key]
        public int toss { get; set; }

        public string facing_up { get; set; }

        public string facing_down { get; set; }
    }
}
