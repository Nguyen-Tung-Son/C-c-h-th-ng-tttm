using Microsoft.EntityFrameworkCore.Migrations;

namespace TS.Migrations
{
    public partial class TinhNang : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TinhNang",
                columns: table => new
                {
                    TNId = table.Column<string>(type: "TEXT", maxLength: 20, nullable: false),
                    TN = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TinhNang", x => x.TNId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TinhNang");
        }
    }
}
