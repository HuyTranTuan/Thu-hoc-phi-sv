using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Democheckbox.Migrations
{
    public partial class ThuHocPhi : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DotThus",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenDotThu = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DonViTinh = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DotThus", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HocKies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenHocKy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HocKies", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Khois",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenKhoi = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Khois", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LoaiHinhThucThus",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenLoaiHinhThucThu = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LoaiHinhThucThus", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LoaiKhoanChis",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenLoaiKhoanChi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ThuTu = table.Column<int>(type: "int", nullable: false),
                    SuDung = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LoaiKhoanChis", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LoaiSanPhams",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenLoaiSanPham = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LoaiSanPhams", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "NguoiThus",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenNguoiThu = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NguoiThus", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TinhChatKhoanThus",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenTinhChatKhoanThu = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TinhChatKhoanThus", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserProfiles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Username = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Firstname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Lastname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Salary = table.Column<int>(type: "int", nullable: false),
                    AboutMe = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserProfiles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Lops",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenLop = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IdKhoi = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lops", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Lops_Khois_IdKhoi",
                        column: x => x.IdKhoi,
                        principalTable: "Khois",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HinhThucThus",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenHinhThucThu = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IdLoaiHinhThucThu = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HinhThucThus", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HinhThucThus_LoaiHinhThucThus_IdLoaiHinhThucThu",
                        column: x => x.IdLoaiHinhThucThu,
                        principalTable: "LoaiHinhThucThus",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "KhoanChis",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenKhoanChi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ThuTu = table.Column<int>(type: "int", nullable: false),
                    SuDung = table.Column<bool>(type: "bit", nullable: false),
                    IdLoaiKhoanChi = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KhoanChis", x => x.Id);
                    table.ForeignKey(
                        name: "FK_KhoanChis_LoaiKhoanChis_IdLoaiKhoanChi",
                        column: x => x.IdLoaiKhoanChi,
                        principalTable: "LoaiKhoanChis",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "LoaiKhoanThus",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenLoaiKhoanThu = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SuDung = table.Column<bool>(type: "bit", nullable: false),
                    ThuTu = table.Column<int>(type: "int", nullable: false),
                    IdTinhChatKhoanThu = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LoaiKhoanThus", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LoaiKhoanThus_TinhChatKhoanThus_IdTinhChatKhoanThu",
                        column: x => x.IdTinhChatKhoanThu,
                        principalTable: "TinhChatKhoanThus",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HocSinhs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenHocSinh = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NgaySinh = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GioiTinh = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IdLop = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HocSinhs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HocSinhs_Lops_IdLop",
                        column: x => x.IdLop,
                        principalTable: "Lops",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "KhoanThuBanHangs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenSanPham = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DonGia = table.Column<int>(type: "int", nullable: false),
                    ThuTu = table.Column<int>(type: "int", nullable: false),
                    SuDung = table.Column<bool>(type: "bit", nullable: false),
                    IdLoaiKhoanThu = table.Column<int>(type: "int", nullable: false),
                    IdLoaiSanPham = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KhoanThuBanHangs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_KhoanThuBanHangs_LoaiKhoanThus_IdLoaiKhoanThu",
                        column: x => x.IdLoaiKhoanThu,
                        principalTable: "LoaiKhoanThus",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_KhoanThuBanHangs_LoaiSanPhams_IdLoaiSanPham",
                        column: x => x.IdLoaiSanPham,
                        principalTable: "LoaiSanPhams",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "KhoanThuCoDinhs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenKhoanThuCoDinh = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DonGia = table.Column<int>(type: "int", nullable: false),
                    ThuTu = table.Column<int>(type: "int", nullable: false),
                    GhiChu = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SuDung = table.Column<bool>(type: "bit", nullable: false),
                    IdLoaiKhoanThu = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KhoanThuCoDinhs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_KhoanThuCoDinhs_LoaiKhoanThus_IdLoaiKhoanThu",
                        column: x => x.IdLoaiKhoanThu,
                        principalTable: "LoaiKhoanThus",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "KhoanThuDichVus",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenKhoanThuDichVu = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DonGia = table.Column<int>(type: "int", nullable: false),
                    ThuTu = table.Column<int>(type: "int", nullable: false),
                    DonGiaTra = table.Column<int>(type: "int", nullable: false),
                    GhiChu = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SuDung = table.Column<bool>(type: "bit", nullable: false),
                    TinhTheoNgay = table.Column<bool>(type: "bit", nullable: false),
                    TraLaiKhiVang = table.Column<bool>(type: "bit", nullable: false),
                    IdLoaiKhoanThu = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KhoanThuDichVus", x => x.Id);
                    table.ForeignKey(
                        name: "FK_KhoanThuDichVus_LoaiKhoanThus_IdLoaiKhoanThu",
                        column: x => x.IdLoaiKhoanThu,
                        principalTable: "LoaiKhoanThus",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BaoCaoCongNos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CongNoHocPhi = table.Column<int>(type: "int", nullable: false),
                    CongNoDichVu = table.Column<int>(type: "int", nullable: false),
                    TongCongNo = table.Column<int>(type: "int", nullable: false),
                    IdHocSinh = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BaoCaoCongNos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BaoCaoCongNos_HocSinhs_IdHocSinh",
                        column: x => x.IdHocSinh,
                        principalTable: "HocSinhs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ChiTietPhieuThus",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TongTien = table.Column<int>(type: "int", nullable: false),
                    KhauTru = table.Column<int>(type: "int", nullable: false),
                    DaThu = table.Column<int>(type: "int", nullable: false),
                    SoTienBangChu = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IdHocSinh = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChiTietPhieuThus", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ChiTietPhieuThus_HocSinhs_IdHocSinh",
                        column: x => x.IdHocSinh,
                        principalTable: "HocSinhs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "KhoanChiMienGiams",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SoTienMienGiam = table.Column<int>(type: "int", nullable: false),
                    SoTienConLai = table.Column<int>(type: "int", nullable: false),
                    GhiChu = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IdHocSinh = table.Column<int>(type: "int", nullable: false),
                    IdKhoanChiMienGiam = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KhoanChiMienGiams", x => x.Id);
                    table.ForeignKey(
                        name: "FK_KhoanChiMienGiams_HocSinhs_IdHocSinh",
                        column: x => x.IdHocSinh,
                        principalTable: "HocSinhs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_KhoanChiMienGiams_KhoanChis_IdKhoanChiMienGiam",
                        column: x => x.IdKhoanChiMienGiam,
                        principalTable: "KhoanChis",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ThuHocPhis",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TongTien = table.Column<int>(type: "int", nullable: false),
                    KhauTru = table.Column<int>(type: "int", nullable: false),
                    PhaiTru = table.Column<int>(type: "int", nullable: false),
                    IdHocSinh = table.Column<int>(type: "int", nullable: false),
                    IdHinhThucThu = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ThuHocPhis", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ThuHocPhis_HinhThucThus_IdHinhThucThu",
                        column: x => x.IdHinhThucThu,
                        principalTable: "HinhThucThus",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ThuHocPhis_HocSinhs_IdHocSinh",
                        column: x => x.IdHocSinh,
                        principalTable: "HocSinhs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "KeHoachThus",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SoTien = table.Column<int>(type: "int", nullable: false),
                    GhiChu = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SoLuongHocSinh = table.Column<int>(type: "int", nullable: false),
                    BatBuoc = table.Column<bool>(type: "bit", nullable: false),
                    IdHocKy = table.Column<int>(type: "int", nullable: false),
                    IdKhoi = table.Column<int>(type: "int", nullable: false),
                    IdHinhThucThu = table.Column<int>(type: "int", nullable: false),
                    IdKhoanThuCoDinh = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KeHoachThus", x => x.Id);
                    table.ForeignKey(
                        name: "FK_KeHoachThus_HinhThucThus_IdHinhThucThu",
                        column: x => x.IdHinhThucThu,
                        principalTable: "HinhThucThus",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_KeHoachThus_HocKies_IdHocKy",
                        column: x => x.IdHocKy,
                        principalTable: "HocKies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_KeHoachThus_KhoanThuCoDinhs_IdKhoanThuCoDinh",
                        column: x => x.IdKhoanThuCoDinh,
                        principalTable: "KhoanThuCoDinhs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_KeHoachThus_Khois_IdKhoi",
                        column: x => x.IdKhoi,
                        principalTable: "Khois",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BaoCaoDangKyDichVus",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DonGia = table.Column<int>(type: "int", nullable: false),
                    SoLuong = table.Column<int>(type: "int", nullable: false),
                    ThanhTien = table.Column<int>(type: "int", nullable: false),
                    IdHocSinh = table.Column<int>(type: "int", nullable: false),
                    IdKhoanThuDichVu = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BaoCaoDangKyDichVus", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BaoCaoDangKyDichVus_HocSinhs_IdHocSinh",
                        column: x => x.IdHocSinh,
                        principalTable: "HocSinhs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BaoCaoDangKyDichVus_KhoanThuDichVus_IdKhoanThuDichVu",
                        column: x => x.IdKhoanThuDichVu,
                        principalTable: "KhoanThuDichVus",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DangKyDichVus",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SoTien = table.Column<int>(type: "int", nullable: false),
                    SoLuong = table.Column<int>(type: "int", nullable: false),
                    GhiChu = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IdKhoanThuDichVu = table.Column<int>(type: "int", nullable: false),
                    IdDotThu = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DangKyDichVus", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DangKyDichVus_DotThus_IdDotThu",
                        column: x => x.IdDotThu,
                        principalTable: "DotThus",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DangKyDichVus_KhoanThuDichVus_IdKhoanThuDichVu",
                        column: x => x.IdKhoanThuDichVu,
                        principalTable: "KhoanThuDichVus",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PhieuThus",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NgayThu = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TongTien = table.Column<int>(type: "int", nullable: false),
                    IdNguoiThu = table.Column<int>(type: "int", nullable: false),
                    IdChiTietPhieuThu = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhieuThus", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PhieuThus_ChiTietPhieuThus_IdChiTietPhieuThu",
                        column: x => x.IdChiTietPhieuThu,
                        principalTable: "ChiTietPhieuThus",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PhieuThus_NguoiThus_IdNguoiThu",
                        column: x => x.IdNguoiThu,
                        principalTable: "NguoiThus",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BaoCaoCongNos_IdHocSinh",
                table: "BaoCaoCongNos",
                column: "IdHocSinh");

            migrationBuilder.CreateIndex(
                name: "IX_BaoCaoDangKyDichVus_IdHocSinh",
                table: "BaoCaoDangKyDichVus",
                column: "IdHocSinh");

            migrationBuilder.CreateIndex(
                name: "IX_BaoCaoDangKyDichVus_IdKhoanThuDichVu",
                table: "BaoCaoDangKyDichVus",
                column: "IdKhoanThuDichVu");

            migrationBuilder.CreateIndex(
                name: "IX_ChiTietPhieuThus_IdHocSinh",
                table: "ChiTietPhieuThus",
                column: "IdHocSinh");

            migrationBuilder.CreateIndex(
                name: "IX_DangKyDichVus_IdDotThu",
                table: "DangKyDichVus",
                column: "IdDotThu");

            migrationBuilder.CreateIndex(
                name: "IX_DangKyDichVus_IdKhoanThuDichVu",
                table: "DangKyDichVus",
                column: "IdKhoanThuDichVu");

            migrationBuilder.CreateIndex(
                name: "IX_HinhThucThus_IdLoaiHinhThucThu",
                table: "HinhThucThus",
                column: "IdLoaiHinhThucThu");

            migrationBuilder.CreateIndex(
                name: "IX_HocSinhs_IdLop",
                table: "HocSinhs",
                column: "IdLop");

            migrationBuilder.CreateIndex(
                name: "IX_KeHoachThus_IdHinhThucThu",
                table: "KeHoachThus",
                column: "IdHinhThucThu");

            migrationBuilder.CreateIndex(
                name: "IX_KeHoachThus_IdHocKy",
                table: "KeHoachThus",
                column: "IdHocKy");

            migrationBuilder.CreateIndex(
                name: "IX_KeHoachThus_IdKhoanThuCoDinh",
                table: "KeHoachThus",
                column: "IdKhoanThuCoDinh");

            migrationBuilder.CreateIndex(
                name: "IX_KeHoachThus_IdKhoi",
                table: "KeHoachThus",
                column: "IdKhoi");

            migrationBuilder.CreateIndex(
                name: "IX_KhoanChiMienGiams_IdHocSinh",
                table: "KhoanChiMienGiams",
                column: "IdHocSinh");

            migrationBuilder.CreateIndex(
                name: "IX_KhoanChiMienGiams_IdKhoanChiMienGiam",
                table: "KhoanChiMienGiams",
                column: "IdKhoanChiMienGiam");

            migrationBuilder.CreateIndex(
                name: "IX_KhoanChis_IdLoaiKhoanChi",
                table: "KhoanChis",
                column: "IdLoaiKhoanChi");

            migrationBuilder.CreateIndex(
                name: "IX_KhoanThuBanHangs_IdLoaiKhoanThu",
                table: "KhoanThuBanHangs",
                column: "IdLoaiKhoanThu");

            migrationBuilder.CreateIndex(
                name: "IX_KhoanThuBanHangs_IdLoaiSanPham",
                table: "KhoanThuBanHangs",
                column: "IdLoaiSanPham");

            migrationBuilder.CreateIndex(
                name: "IX_KhoanThuCoDinhs_IdLoaiKhoanThu",
                table: "KhoanThuCoDinhs",
                column: "IdLoaiKhoanThu");

            migrationBuilder.CreateIndex(
                name: "IX_KhoanThuDichVus_IdLoaiKhoanThu",
                table: "KhoanThuDichVus",
                column: "IdLoaiKhoanThu");

            migrationBuilder.CreateIndex(
                name: "IX_LoaiKhoanThus_IdTinhChatKhoanThu",
                table: "LoaiKhoanThus",
                column: "IdTinhChatKhoanThu");

            migrationBuilder.CreateIndex(
                name: "IX_Lops_IdKhoi",
                table: "Lops",
                column: "IdKhoi");

            migrationBuilder.CreateIndex(
                name: "IX_PhieuThus_IdChiTietPhieuThu",
                table: "PhieuThus",
                column: "IdChiTietPhieuThu");

            migrationBuilder.CreateIndex(
                name: "IX_PhieuThus_IdNguoiThu",
                table: "PhieuThus",
                column: "IdNguoiThu");

            migrationBuilder.CreateIndex(
                name: "IX_ThuHocPhis_IdHinhThucThu",
                table: "ThuHocPhis",
                column: "IdHinhThucThu");

            migrationBuilder.CreateIndex(
                name: "IX_ThuHocPhis_IdHocSinh",
                table: "ThuHocPhis",
                column: "IdHocSinh");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BaoCaoCongNos");

            migrationBuilder.DropTable(
                name: "BaoCaoDangKyDichVus");

            migrationBuilder.DropTable(
                name: "DangKyDichVus");

            migrationBuilder.DropTable(
                name: "KeHoachThus");

            migrationBuilder.DropTable(
                name: "KhoanChiMienGiams");

            migrationBuilder.DropTable(
                name: "KhoanThuBanHangs");

            migrationBuilder.DropTable(
                name: "PhieuThus");

            migrationBuilder.DropTable(
                name: "ThuHocPhis");

            migrationBuilder.DropTable(
                name: "UserProfiles");

            migrationBuilder.DropTable(
                name: "DotThus");

            migrationBuilder.DropTable(
                name: "KhoanThuDichVus");

            migrationBuilder.DropTable(
                name: "HocKies");

            migrationBuilder.DropTable(
                name: "KhoanThuCoDinhs");

            migrationBuilder.DropTable(
                name: "KhoanChis");

            migrationBuilder.DropTable(
                name: "LoaiSanPhams");

            migrationBuilder.DropTable(
                name: "ChiTietPhieuThus");

            migrationBuilder.DropTable(
                name: "NguoiThus");

            migrationBuilder.DropTable(
                name: "HinhThucThus");

            migrationBuilder.DropTable(
                name: "LoaiKhoanThus");

            migrationBuilder.DropTable(
                name: "LoaiKhoanChis");

            migrationBuilder.DropTable(
                name: "HocSinhs");

            migrationBuilder.DropTable(
                name: "LoaiHinhThucThus");

            migrationBuilder.DropTable(
                name: "TinhChatKhoanThus");

            migrationBuilder.DropTable(
                name: "Lops");

            migrationBuilder.DropTable(
                name: "Khois");
        }
    }
}
