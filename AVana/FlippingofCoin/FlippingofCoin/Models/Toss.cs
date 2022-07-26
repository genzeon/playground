using System.ComponentModel.DataAnnotations;

namespace FlippingofCoin.Models
{
    public class Toss
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public int FaceUp { get; set; }
        public int Tosscount { get; set; }

     
    }
}
