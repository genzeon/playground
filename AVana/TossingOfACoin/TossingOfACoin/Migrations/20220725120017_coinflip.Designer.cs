﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TossingOfACoin.Data;

#nullable disable

namespace TossingOfACoin.Migrations
{
    [DbContext(typeof(DataContest))]
    [Migration("20220725120017_coinflip")]
    partial class coinflip
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("TossingOfACoin.Toss", b =>
                {
                    b.Property<int>("toss")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("toss"), 1L, 1);

                    b.Property<string>("Downside")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Upside")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("toss");

                    b.ToTable("toss");
                });
#pragma warning restore 612, 618
        }
    }
}
