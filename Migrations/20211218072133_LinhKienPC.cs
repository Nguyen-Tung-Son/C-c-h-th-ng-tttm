using Microsoft.EntityFrameworkCore.Migrations;

namespace TS.Migrations
{
    public partial class LinhKienPC : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LinhKienPC",
                columns: table => new
                {
                    LinhKienPCId = table.Column<string>(type: "TEXT", maxLength: 20, nullable: false),
                    LinhKienPCName = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    Price = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    HSXs = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    type = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LinhKienPC", x => x.LinhKienPCId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LinhKienPC");
        }
    }
}
