using Microsoft.EntityFrameworkCore.Migrations;

namespace Your.Namespace
{
    public partial class InitialCreate2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SoTienConLai",
                table: "KhoanChiMienGiams");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "SoTienConLai",
                table: "KhoanChiMienGiams",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
