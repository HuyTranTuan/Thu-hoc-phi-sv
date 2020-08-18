using Microsoft.EntityFrameworkCore.Migrations;

namespace Your.Namespace
{
    public partial class InitialCreate13 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "SoLuong",
                table: "ThuHocPhis",
                newName: "SoLuong3");

            migrationBuilder.AddColumn<int>(
                name: "SoLuong1",
                table: "ThuHocPhis",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SoLuong2",
                table: "ThuHocPhis",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SoLuong1",
                table: "ThuHocPhis");

            migrationBuilder.DropColumn(
                name: "SoLuong2",
                table: "ThuHocPhis");

            migrationBuilder.RenameColumn(
                name: "SoLuong3",
                table: "ThuHocPhis",
                newName: "SoLuong");
        }
    }
}
