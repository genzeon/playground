using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ContactManagerProject.Models
{
    [Table("AddressBook")]
    public partial class AddressBook
    {
        [Key]
        [Column("PKAddressId")]
        public int PkaddressId { get; set; }
        [Column("FKStateId")]
        public int FkstateId { get; set; }
        [Column("FKUserId")]
        public int FkuserId { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string FirstName { get; set; } = null!;
        [StringLength(50)]
        [Unicode(false)]
        public string? LastName { get; set; }
        [StringLength(50)]
        [data]
        [Unicode(false)]
        public string EmailId { get; set; } = null!;
        [StringLength(50)]
        [Unicode(false)]
        public string PhoneNo { get; set; } = null!;
        [StringLength(50)]
        [Unicode(false)]
        public string? Address1 { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string Address2 { get; set; } = null!;
        [StringLength(50)]
        [Unicode(false)]
        public string Street { get; set; } = null!;
        [StringLength(50)]
        [Unicode(false)]
        public string City { get; set; } = null!;
        public long ZipCode { get; set; }
        public bool IsActive { get; set; }

        [ForeignKey("FkstateId")]
        [InverseProperty("AddressBooks")]
        public virtual State? Fkstate { get; set; } = null!;
       
        [ForeignKey("FkuserId")]
        [InverseProperty("AddressBooks")]
        public virtual UserDetail? Fkuser { get; set; } = null!;
    }
}
