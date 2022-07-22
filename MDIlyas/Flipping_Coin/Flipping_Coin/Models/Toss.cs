using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Flipping_Coin.Models
{
    public class Toss
    {

        public Toss(string side1,string side2)
        {
            facing_up = side1;
            facing_down = side2;
        }

        [Key]
        public int toss { get; set; }

        public string facing_up { get; set; }

        public string facing_down { get; set; }
    }
}
