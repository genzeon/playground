using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ContactManagerProject.Models
{
    [Table("Country")]
    [Index("CountryName", Name = "UQ__Country__E056F20193DBDFE8", IsUnique = true)]
    public partial class Country
    {
        public Country()
        {
            States = new HashSet<State>();
        }

        [Key]
        [Column("PKCountryId")]
        public int PkcountryId { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string CountryName { get; set; } = null!;
        public long ZipCodeStart { get; set; }
        public long ZipCodeEnd { get; set; }
        public bool IsActive { get; set; }

        [InverseProperty("Fkcountry")]
        public virtual ICollection<State> States { get; set; }
    }
}
