using Microsoft.EntityFrameworkCore.Migrations;

namespace Your.Namespace
{
    public partial class InitialCreate11 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "TenKhoanChiMienGiam",
                table: "KhoanChiMienGiams",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TenKhoanChiMienGiam",
                table: "KhoanChiMienGiams");
        }
    }
}
