using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TossingOfACoin.Migrations
{
    public partial class coinflip : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "toss",
                columns: table => new
                {
                    toss = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Upside = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Downside = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_toss", x => x.toss);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "toss");
        }
    }
}
