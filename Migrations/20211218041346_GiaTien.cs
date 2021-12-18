using Microsoft.EntityFrameworkCore.Migrations;

namespace TS.Migrations
{
    public partial class GiaTien : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "GiaTien",
                columns: table => new
                {
                    GiaTienId = table.Column<string>(type: "TEXT", maxLength: 20, nullable: false),
                    GiaTiens = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GiaTien", x => x.GiaTienId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GiaTien");
        }
    }
}
