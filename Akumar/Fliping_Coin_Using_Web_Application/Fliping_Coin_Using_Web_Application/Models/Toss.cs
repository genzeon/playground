using System.ComponentModel.DataAnnotations;

namespace Fliping_Coin_Using_Web_Application.Models
{
    public class Toss
    {
        //public int Id { get; set; }
        //public string Name { get; set; }
        //public string Face_Value { get; set; }  

        //public int Toss_Count { get; set; }

        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public int FaceValue { get; set; }
        public int TossCount { get; set; }  


    }
}
