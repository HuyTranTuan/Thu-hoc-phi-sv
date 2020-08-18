using Microsoft.EntityFrameworkCore.Migrations;

namespace Your.Namespace
{
    public partial class InitialCreate3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SoTien",
                table: "DangKyDichVus");

            migrationBuilder.AddColumn<string>(
                name: "DonViTinh",
                table: "DangKyDichVus",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DonViTinh",
                table: "DangKyDichVus");

            migrationBuilder.AddColumn<int>(
                name: "SoTien",
                table: "DangKyDichVus",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
