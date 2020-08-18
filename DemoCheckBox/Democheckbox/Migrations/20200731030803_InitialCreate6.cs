using Microsoft.EntityFrameworkCore.Migrations;

namespace Your.Namespace
{
    public partial class InitialCreate6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "KhauTru",
                table: "ThuHocPhis");

            migrationBuilder.RenameColumn(
                name: "TongTien",
                table: "ThuHocPhis",
                newName: "IdKhoanThu");

            migrationBuilder.RenameColumn(
                name: "PhaiTru",
                table: "ThuHocPhis",
                newName: "IdKhoanChiMienGiam");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "IdKhoanThu",
                table: "ThuHocPhis",
                newName: "TongTien");

            migrationBuilder.RenameColumn(
                name: "IdKhoanChiMienGiam",
                table: "ThuHocPhis",
                newName: "PhaiTru");

            migrationBuilder.AddColumn<int>(
                name: "KhauTru",
                table: "ThuHocPhis",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
