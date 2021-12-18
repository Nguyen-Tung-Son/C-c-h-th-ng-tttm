using Microsoft.EntityFrameworkCore.Migrations;

namespace TS.Migrations
{
    public partial class LKPC : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LKPC",
                columns: table => new
                {
                    LKPCId = table.Column<string>(type: "TEXT", maxLength: 20, nullable: false),
                    LKPCName = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LKPC", x => x.LKPCId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LKPC");
        }
    }
}
