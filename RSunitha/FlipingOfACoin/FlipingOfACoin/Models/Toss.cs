using System.ComponentModel.DataAnnotations;
namespace FlipingOfACoin.Models

{
    public class Toss
    {
        [Key]
        public int toss { get; set; } 

        public string Upside { get; set; }  
        
        public string Downside { get; set; }  

    }
}
