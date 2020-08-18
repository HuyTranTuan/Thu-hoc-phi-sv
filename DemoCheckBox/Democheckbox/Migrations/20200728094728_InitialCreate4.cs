using Microsoft.EntityFrameworkCore.Migrations;

namespace Your.Namespace
{
    public partial class InitialCreate4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "IdHocSinh",
                table: "DangKyDichVus",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_DangKyDichVus_IdHocSinh",
                table: "DangKyDichVus",
                column: "IdHocSinh");

            migrationBuilder.AddForeignKey(
                name: "FK_DangKyDichVus_HocSinhs_IdHocSinh",
                table: "DangKyDichVus",
                column: "IdHocSinh",
                principalTable: "HocSinhs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DangKyDichVus_HocSinhs_IdHocSinh",
                table: "DangKyDichVus");

            migrationBuilder.DropIndex(
                name: "IX_DangKyDichVus_IdHocSinh",
                table: "DangKyDichVus");

            migrationBuilder.DropColumn(
                name: "IdHocSinh",
                table: "DangKyDichVus");
        }
    }
}
