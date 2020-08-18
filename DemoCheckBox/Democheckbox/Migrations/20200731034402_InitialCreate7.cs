using Microsoft.EntityFrameworkCore.Migrations;

namespace Your.Namespace
{
    public partial class InitialCreate7 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "IdNguoiThu",
                table: "ThuHocPhis",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IdNguoiThu",
                table: "ThuHocPhis");
        }
    }
}
