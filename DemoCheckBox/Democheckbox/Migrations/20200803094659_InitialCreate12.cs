using Microsoft.EntityFrameworkCore.Migrations;

namespace Your.Namespace
{
    public partial class InitialCreate12 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "IdKhoanThu",
                table: "ThuHocPhis",
                newName: "IdKhoanThuDichVu");

            migrationBuilder.AddColumn<int>(
                name: "IdKhoanThuBanHang",
                table: "ThuHocPhis",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IdKhoanThuCoDinh",
                table: "ThuHocPhis",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IdKhoanThuBanHang",
                table: "ThuHocPhis");

            migrationBuilder.DropColumn(
                name: "IdKhoanThuCoDinh",
                table: "ThuHocPhis");

            migrationBuilder.RenameColumn(
                name: "IdKhoanThuDichVu",
                table: "ThuHocPhis",
                newName: "IdKhoanThu");
        }
    }
}
