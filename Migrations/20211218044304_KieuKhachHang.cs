using Microsoft.EntityFrameworkCore.Migrations;

namespace TS.Migrations
{
    public partial class KieuKhachHang : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "KieuKhachHang",
                columns: table => new
                {
                    KKHId = table.Column<string>(type: "TEXT", maxLength: 20, nullable: false),
                    KKH = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KieuKhachHang", x => x.KKHId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "KieuKhachHang");
        }
    }
}
