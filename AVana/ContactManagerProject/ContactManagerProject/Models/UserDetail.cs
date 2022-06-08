using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ContactManagerProject.Models
{
    [Index("UserName", Name = "UQ__UserDeta__C9F28456B6B367C8", IsUnique = true)]
    public partial class UserDetail
    {
        public UserDetail()
        {
            AddressBooks = new HashSet<AddressBook>();
        }

        [Key]
        [Column("PKUserId")]
        public int PkuserId { get; set; }
        [StringLength(50)]
        [Unicode(false)]

        public string UserName { get; set; } = null!;
        [StringLength(50)]
        [Unicode(false)]
        [DataType(DataType.Password)]
        [Required]
        [MinLength(6, ErrorMessage = "Please enter a valid Password with Mimimum 6 charaters.")]
        public string Password { get; set; } = null!;
        [StringLength(50)]
        [Unicode(false)]
        public string FirstName { get; set; } = null!;
        [StringLength(50)]
        [Unicode(false)]
        public string? LastName { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string EmailId { get; set; } = null!;
        [StringLength(50)]
        [Unicode(false)]
        [MaxLength(10)]
        [MinLength(10,ErrorMessage ="Please enter a valid PhoneNo.")]
        public string PhoneNo { get; set; } = null!;
        public bool IsActive { get; set; }

        [InverseProperty("Fkuser")]
        public virtual ICollection<AddressBook> AddressBooks { get; set; }
    }
}
