using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CoinWeb.Migrations
{
    public partial class TossResults : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TossResults",
                columns: table => new
                {
                    No_Of_Toss = table.Column<int>(type: "int", nullable: false),                        
                    Result = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TossResults", x => x.No_Of_Toss);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TossResults");
        }
    }
}
