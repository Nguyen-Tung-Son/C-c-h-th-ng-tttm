using Microsoft.EntityFrameworkCore.Migrations;

namespace TS.Migrations
{
    public partial class HSX : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "HSX",
                columns: table => new
                {
                    HSXId = table.Column<string>(type: "TEXT", maxLength: 20, nullable: false),
                    HSXs = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HSX", x => x.HSXId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HSX");
        }
    }
}
