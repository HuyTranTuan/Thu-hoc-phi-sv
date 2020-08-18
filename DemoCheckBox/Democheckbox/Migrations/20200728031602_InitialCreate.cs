using Microsoft.EntityFrameworkCore.Migrations;

namespace Your.Namespace
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_KhoanChiMienGiams_KhoanChis_IdKhoanChiMienGiam",
                table: "KhoanChiMienGiams");

            migrationBuilder.RenameColumn(
                name: "IdKhoanChiMienGiam",
                table: "KhoanChiMienGiams",
                newName: "IdKhoanChi");

            migrationBuilder.RenameIndex(
                name: "IX_KhoanChiMienGiams_IdKhoanChiMienGiam",
                table: "KhoanChiMienGiams",
                newName: "IX_KhoanChiMienGiams_IdKhoanChi");

            migrationBuilder.AddForeignKey(
                name: "FK_KhoanChiMienGiams_KhoanChis_IdKhoanChi",
                table: "KhoanChiMienGiams",
                column: "IdKhoanChi",
                principalTable: "KhoanChis",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_KhoanChiMienGiams_KhoanChis_IdKhoanChi",
                table: "KhoanChiMienGiams");

            migrationBuilder.RenameColumn(
                name: "IdKhoanChi",
                table: "KhoanChiMienGiams",
                newName: "IdKhoanChiMienGiam");

            migrationBuilder.RenameIndex(
                name: "IX_KhoanChiMienGiams_IdKhoanChi",
                table: "KhoanChiMienGiams",
                newName: "IX_KhoanChiMienGiams_IdKhoanChiMienGiam");

            migrationBuilder.AddForeignKey(
                name: "FK_KhoanChiMienGiams_KhoanChis_IdKhoanChiMienGiam",
                table: "KhoanChiMienGiams",
                column: "IdKhoanChiMienGiam",
                principalTable: "KhoanChis",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
