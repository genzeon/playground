using System.ComponentModel.DataAnnotations;

namespace ContactManagerProject.Models
{
    public class Login
    {
        [Key]
        public string UserName { get; set; }

        [DataType(DataType.Password)]
        [Required]
        public string Password { get; set; }
    }
}
