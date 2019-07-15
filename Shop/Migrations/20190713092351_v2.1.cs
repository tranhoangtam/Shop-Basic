using Microsoft.EntityFrameworkCore.Migrations;

namespace Shop.Migrations
{
    public partial class v21 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "TenHH",
                table: "HangHoa",
                newName: "TenHh");

            migrationBuilder.RenameColumn(
                name: "MaHH",
                table: "HangHoa",
                newName: "MaHh");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "TenHh",
                table: "HangHoa",
                newName: "TenHH");

            migrationBuilder.RenameColumn(
                name: "MaHh",
                table: "HangHoa",
                newName: "MaHH");
        }
    }
}
