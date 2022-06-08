using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ContactManagerProject.Models
{
    [Table("State")]
    public partial class State
    {
        public State()
        {
            AddressBooks = new HashSet<AddressBook>();
        }

        [Key]
        [Column("PKStateId")]
        public int PkstateId { get; set; }
        [Column("FKCountryId")]
        public int FkcountryId { get; set; }
        [StringLength(20)]
        [Unicode(false)]
        public string StateName { get; set; } = null!;
        public bool IsActive { get; set; }

        [ForeignKey("FkcountryId")]
        [InverseProperty("States")]
        public virtual Country? Fkcountry { get; set; } = null!;
        [InverseProperty("Fkstate")]
        public virtual ICollection<AddressBook> AddressBooks { get; set; }
    }
}
