// <auto-generated />
using CoinFlippingDemoApp.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CoinFlippingDemoApp.Migrations
{
    [DbContext(typeof(CoinContext))]
    partial class CoinContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("CoinFlippingDemoApp.Models.Flip", b =>
                {
                    b.Property<int>("flip")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("flip"), 1L, 1);

                    b.Property<string>("_Down")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("_Up")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("flip");

                    b.ToTable("Coins");
                });
#pragma warning restore 612, 618
        }
    }
}
