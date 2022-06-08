using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using ContactManagerProject.Models;

namespace ContactManagerProject.Models
{
    public partial class Data : DbContext
    {
        public Data()
        {
        }

        public Data(DbContextOptions<Data> options)
            : base(options)
        {
        }

        public virtual DbSet<AddressBook> AddressBooks { get; set; } = null!;
        public virtual DbSet<Country> Countries { get; set; } = null!;
        public virtual DbSet<State> States { get; set; } = null!;
        public virtual DbSet<UserDetail> UserDetails { get; set; } = null!;
        public DbSet<ContactManagerProject.Models.Login> Login { get; set; }

       
    }
}
