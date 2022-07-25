using System.ComponentModel.DataAnnotations;

namespace coinstimulate.Models
{
    public class Coindb
    {
        [Key]
        public int Id { get; set; } 
        public string Name { get; set; }
        public int FaceUp { get; set; } 
        public int TossCount { get; set; }  
         
    }
}
