using Microsoft.EntityFrameworkCore.Migrations;

namespace Your.Namespace
{
    public partial class InitialCreate14 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_KhoanChiMienGiams_HocSinhs_IdHocSinh",
                table: "KhoanChiMienGiams");

            migrationBuilder.DropIndex(
                name: "IX_KhoanChiMienGiams_IdHocSinh",
                table: "KhoanChiMienGiams");

            migrationBuilder.DropColumn(
                name: "IdHocSinh",
                table: "KhoanChiMienGiams");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "IdHocSinh",
                table: "KhoanChiMienGiams",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_KhoanChiMienGiams_IdHocSinh",
                table: "KhoanChiMienGiams",
                column: "IdHocSinh");

            migrationBuilder.AddForeignKey(
                name: "FK_KhoanChiMienGiams_HocSinhs_IdHocSinh",
                table: "KhoanChiMienGiams",
                column: "IdHocSinh",
                principalTable: "HocSinhs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
