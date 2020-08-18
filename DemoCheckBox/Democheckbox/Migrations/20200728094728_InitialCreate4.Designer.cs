﻿// <auto-generated />
using System;
using Democheckbox;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Your.Namespace
{
    [DbContext(typeof(UserProfileDbContext))]
    [Migration("20200728094728_InitialCreate4")]
    partial class InitialCreate4
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0-preview.7.20365.15");

            modelBuilder.Entity("Democheckbox.Domain.UserProfile", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("AboutMe")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Country")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Firstname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Lastname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Salary")
                        .HasColumnType("int");

                    b.Property<string>("Username")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("UserProfiles");
                });

            modelBuilder.Entity("Democheckbox.Model.BaoCaoCongNo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("CongNoDichVu")
                        .HasColumnType("int");

                    b.Property<int>("CongNoHocPhi")
                        .HasColumnType("int");

                    b.Property<int>("IdHocSinh")
                        .HasColumnType("int");

                    b.Property<int>("TongCongNo")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("IdHocSinh");

                    b.ToTable("BaoCaoCongNos");
                });

            modelBuilder.Entity("Democheckbox.Model.BaoCaoDangKyDichVu", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("DonGia")
                        .HasColumnType("int");

                    b.Property<int>("IdHocSinh")
                        .HasColumnType("int");

                    b.Property<int>("IdKhoanThuDichVu")
                        .HasColumnType("int");

                    b.Property<int>("SoLuong")
                        .HasColumnType("int");

                    b.Property<int>("ThanhTien")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("IdHocSinh");

                    b.HasIndex("IdKhoanThuDichVu");

                    b.ToTable("BaoCaoDangKyDichVus");
                });

            modelBuilder.Entity("Democheckbox.Model.ChiTietPhieuThu", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("DaThu")
                        .HasColumnType("int");

                    b.Property<int>("IdHocSinh")
                        .HasColumnType("int");

                    b.Property<int>("KhauTru")
                        .HasColumnType("int");

                    b.Property<string>("SoTienBangChu")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TongTien")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("IdHocSinh");

                    b.ToTable("ChiTietPhieuThus");
                });

            modelBuilder.Entity("Democheckbox.Model.DangKyDichVu", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("DonViTinh")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("GhiChu")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("IdDotThu")
                        .HasColumnType("int");

                    b.Property<int>("IdHocSinh")
                        .HasColumnType("int");

                    b.Property<int>("IdKhoanThuDichVu")
                        .HasColumnType("int");

                    b.Property<int>("SoLuong")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("IdDotThu");

                    b.HasIndex("IdHocSinh");

                    b.HasIndex("IdKhoanThuDichVu");

                    b.ToTable("DangKyDichVus");
                });

            modelBuilder.Entity("Democheckbox.Model.DotThu", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("DonViTinh")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TenDotThu")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("DotThus");
                });

            modelBuilder.Entity("Democheckbox.Model.HinhThucThu", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("IdLoaiHinhThucThu")
                        .HasColumnType("int");

                    b.Property<string>("TenHinhThucThu")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("IdLoaiHinhThucThu");

                    b.ToTable("HinhThucThus");
                });

            modelBuilder.Entity("Democheckbox.Model.HocKy", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("TenHocKy")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("HocKies");
                });

            modelBuilder.Entity("Democheckbox.Model.HocSinh", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("GioiTinh")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("IdLop")
                        .HasColumnType("int");

                    b.Property<DateTime>("NgaySinh")
                        .HasColumnType("datetime2");

                    b.Property<string>("TenHocSinh")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("IdLop");

                    b.ToTable("HocSinhs");
                });

            modelBuilder.Entity("Democheckbox.Model.KeHoachThu", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<bool>("BatBuoc")
                        .HasColumnType("bit");

                    b.Property<string>("GhiChu")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("IdHinhThucThu")
                        .HasColumnType("int");

                    b.Property<int>("IdHocKy")
                        .HasColumnType("int");

                    b.Property<int>("IdKhoanThuCoDinh")
                        .HasColumnType("int");

                    b.Property<int>("IdKhoi")
                        .HasColumnType("int");

                    b.Property<int>("SoLuongHocSinh")
                        .HasColumnType("int");

                    b.Property<int>("SoTien")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("IdHinhThucThu");

                    b.HasIndex("IdHocKy");

                    b.HasIndex("IdKhoanThuCoDinh");

                    b.HasIndex("IdKhoi");

                    b.ToTable("KeHoachThus");
                });

            modelBuilder.Entity("Democheckbox.Model.KhoanChi", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("IdLoaiKhoanChi")
                        .HasColumnType("int");

                    b.Property<bool>("SuDung")
                        .HasColumnType("bit");

                    b.Property<string>("TenKhoanChi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ThuTu")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("IdLoaiKhoanChi");

                    b.ToTable("KhoanChis");
                });

            modelBuilder.Entity("Democheckbox.Model.KhoanChiMienGiam", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("GhiChu")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("IdHocSinh")
                        .HasColumnType("int");

                    b.Property<int>("IdKhoanChi")
                        .HasColumnType("int");

                    b.Property<int>("SoTienMienGiam")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("IdHocSinh");

                    b.HasIndex("IdKhoanChi");

                    b.ToTable("KhoanChiMienGiams");
                });

            modelBuilder.Entity("Democheckbox.Model.KhoanThuBanHang", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("DonGia")
                        .HasColumnType("int");

                    b.Property<int>("IdLoaiKhoanThu")
                        .HasColumnType("int");

                    b.Property<int>("IdLoaiSanPham")
                        .HasColumnType("int");

                    b.Property<bool>("SuDung")
                        .HasColumnType("bit");

                    b.Property<string>("TenSanPham")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ThuTu")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("IdLoaiKhoanThu");

                    b.HasIndex("IdLoaiSanPham");

                    b.ToTable("KhoanThuBanHangs");
                });

            modelBuilder.Entity("Democheckbox.Model.KhoanThuCoDinh", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("DonGia")
                        .HasColumnType("int");

                    b.Property<string>("GhiChu")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("IdLoaiKhoanThu")
                        .HasColumnType("int");

                    b.Property<bool>("SuDung")
                        .HasColumnType("bit");

                    b.Property<string>("TenKhoanThuCoDinh")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ThuTu")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("IdLoaiKhoanThu");

                    b.ToTable("KhoanThuCoDinhs");
                });

            modelBuilder.Entity("Democheckbox.Model.KhoanThuDichVu", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("DonGia")
                        .HasColumnType("int");

                    b.Property<int>("DonGiaTra")
                        .HasColumnType("int");

                    b.Property<string>("GhiChu")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("IdLoaiKhoanThu")
                        .HasColumnType("int");

                    b.Property<bool>("SuDung")
                        .HasColumnType("bit");

                    b.Property<string>("TenKhoanThuDichVu")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ThuTu")
                        .HasColumnType("int");

                    b.Property<bool>("TinhTheoNgay")
                        .HasColumnType("bit");

                    b.Property<bool>("TraLaiKhiVang")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("IdLoaiKhoanThu");

                    b.ToTable("KhoanThuDichVus");
                });

            modelBuilder.Entity("Democheckbox.Model.Khoi", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("TenKhoi")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Khois");
                });

            modelBuilder.Entity("Democheckbox.Model.LoaiHinhThucThu", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("TenLoaiHinhThucThu")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("LoaiHinhThucThus");
                });

            modelBuilder.Entity("Democheckbox.Model.LoaiKhoanChi", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<bool>("SuDung")
                        .HasColumnType("bit");

                    b.Property<string>("TenLoaiKhoanChi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ThuTu")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("LoaiKhoanChis");
                });

            modelBuilder.Entity("Democheckbox.Model.LoaiKhoanThu", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("IdTinhChatKhoanThu")
                        .HasColumnType("int");

                    b.Property<bool>("SuDung")
                        .HasColumnType("bit");

                    b.Property<string>("TenLoaiKhoanThu")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ThuTu")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("IdTinhChatKhoanThu");

                    b.ToTable("LoaiKhoanThus");
                });

            modelBuilder.Entity("Democheckbox.Model.LoaiSanPham", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("TenLoaiSanPham")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("LoaiSanPhams");
                });

            modelBuilder.Entity("Democheckbox.Model.Lop", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("IdKhoi")
                        .HasColumnType("int");

                    b.Property<string>("TenLop")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("IdKhoi");

                    b.ToTable("Lops");
                });

            modelBuilder.Entity("Democheckbox.Model.NguoiThu", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("TenNguoiThu")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("NguoiThus");
                });

            modelBuilder.Entity("Democheckbox.Model.PhieuThu", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("IdChiTietPhieuThu")
                        .HasColumnType("int");

                    b.Property<int>("IdNguoiThu")
                        .HasColumnType("int");

                    b.Property<DateTime>("NgayThu")
                        .HasColumnType("datetime2");

                    b.Property<int>("TongTien")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("IdChiTietPhieuThu");

                    b.HasIndex("IdNguoiThu");

                    b.ToTable("PhieuThus");
                });

            modelBuilder.Entity("Democheckbox.Model.ThuHocPhi", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("IdHinhThucThu")
                        .HasColumnType("int");

                    b.Property<int>("IdHocSinh")
                        .HasColumnType("int");

                    b.Property<int>("KhauTru")
                        .HasColumnType("int");

                    b.Property<int>("PhaiTru")
                        .HasColumnType("int");

                    b.Property<int>("TongTien")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("IdHinhThucThu");

                    b.HasIndex("IdHocSinh");

                    b.ToTable("ThuHocPhis");
                });

            modelBuilder.Entity("Democheckbox.Model.TinhChatKhoanThu", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("TenTinhChatKhoanThu")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("TinhChatKhoanThus");
                });

            modelBuilder.Entity("Democheckbox.Model.BaoCaoCongNo", b =>
                {
                    b.HasOne("Democheckbox.Model.HocSinh", "hocSinh")
                        .WithMany("baoCaoCongNos")
                        .HasForeignKey("IdHocSinh")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Democheckbox.Model.BaoCaoDangKyDichVu", b =>
                {
                    b.HasOne("Democheckbox.Model.HocSinh", "hocSinh")
                        .WithMany("baoCaoDangKyDichVus")
                        .HasForeignKey("IdHocSinh")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Democheckbox.Model.KhoanThuDichVu", "khoanThuDichVu")
                        .WithMany("baoCaoDangKyDichVus")
                        .HasForeignKey("IdKhoanThuDichVu")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Democheckbox.Model.ChiTietPhieuThu", b =>
                {
                    b.HasOne("Democheckbox.Model.HocSinh", "hocSinh")
                        .WithMany("chiTietPhieuThus")
                        .HasForeignKey("IdHocSinh")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Democheckbox.Model.DangKyDichVu", b =>
                {
                    b.HasOne("Democheckbox.Model.DotThu", "dotThu")
                        .WithMany("dangKyDichVus")
                        .HasForeignKey("IdDotThu")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Democheckbox.Model.HocSinh", "hocSinh")
                        .WithMany("dangKyDichVus")
                        .HasForeignKey("IdHocSinh")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Democheckbox.Model.KhoanThuDichVu", "khoanThuDichVu")
                        .WithMany("dangKyDichVus")
                        .HasForeignKey("IdKhoanThuDichVu")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Democheckbox.Model.HinhThucThu", b =>
                {
                    b.HasOne("Democheckbox.Model.LoaiHinhThucThu", "loaiHinhThucThu")
                        .WithMany("hinhThucThus")
                        .HasForeignKey("IdLoaiHinhThucThu")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Democheckbox.Model.HocSinh", b =>
                {
                    b.HasOne("Democheckbox.Model.Lop", "lop")
                        .WithMany("hocSinhs")
                        .HasForeignKey("IdLop")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Democheckbox.Model.KeHoachThu", b =>
                {
                    b.HasOne("Democheckbox.Model.HinhThucThu", "hinhThucThu")
                        .WithMany("keHoachThus")
                        .HasForeignKey("IdHinhThucThu")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Democheckbox.Model.HocKy", "hocKy")
                        .WithMany("keHoachThus")
                        .HasForeignKey("IdHocKy")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Democheckbox.Model.KhoanThuCoDinh", "khoanThuCoDinh")
                        .WithMany("keHoachThus")
                        .HasForeignKey("IdKhoanThuCoDinh")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Democheckbox.Model.Khoi", "khoi")
                        .WithMany("keHoachThus")
                        .HasForeignKey("IdKhoi")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Democheckbox.Model.KhoanChi", b =>
                {
                    b.HasOne("Democheckbox.Model.LoaiKhoanChi", "loaiKhoanChi")
                        .WithMany("khoanChis")
                        .HasForeignKey("IdLoaiKhoanChi")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Democheckbox.Model.KhoanChiMienGiam", b =>
                {
                    b.HasOne("Democheckbox.Model.HocSinh", "hocSinh")
                        .WithMany("khoanChiMienGiams")
                        .HasForeignKey("IdHocSinh")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Democheckbox.Model.KhoanChi", "khoanChi")
                        .WithMany("khoanChiMienGiams")
                        .HasForeignKey("IdKhoanChi")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Democheckbox.Model.KhoanThuBanHang", b =>
                {
                    b.HasOne("Democheckbox.Model.LoaiKhoanThu", "loaiKhoanThu")
                        .WithMany("khoanThuBanHangs")
                        .HasForeignKey("IdLoaiKhoanThu")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Democheckbox.Model.LoaiSanPham", "loaiSanPham")
                        .WithMany("khoanThuBanHangs")
                        .HasForeignKey("IdLoaiSanPham")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Democheckbox.Model.KhoanThuCoDinh", b =>
                {
                    b.HasOne("Democheckbox.Model.LoaiKhoanThu", "loaiKhoanThu")
                        .WithMany("khoanThuCoDinhs")
                        .HasForeignKey("IdLoaiKhoanThu")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Democheckbox.Model.KhoanThuDichVu", b =>
                {
                    b.HasOne("Democheckbox.Model.LoaiKhoanThu", "loaiKhoanThu")
                        .WithMany("khoanThuDichVus")
                        .HasForeignKey("IdLoaiKhoanThu")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Democheckbox.Model.LoaiKhoanThu", b =>
                {
                    b.HasOne("Democheckbox.Model.TinhChatKhoanThu", "tinhChatKhoanThu")
                        .WithMany("loaiKhoanThus")
                        .HasForeignKey("IdTinhChatKhoanThu")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Democheckbox.Model.Lop", b =>
                {
                    b.HasOne("Democheckbox.Model.Khoi", "khoi")
                        .WithMany("lops")
                        .HasForeignKey("IdKhoi")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Democheckbox.Model.PhieuThu", b =>
                {
                    b.HasOne("Democheckbox.Model.ChiTietPhieuThu", "chiTietPhieuThu")
                        .WithMany("phieuThus")
                        .HasForeignKey("IdChiTietPhieuThu")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Democheckbox.Model.NguoiThu", "nguoiThu")
                        .WithMany("phieuThus")
                        .HasForeignKey("IdNguoiThu")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Democheckbox.Model.ThuHocPhi", b =>
                {
                    b.HasOne("Democheckbox.Model.HinhThucThu", "hinhThucThu")
                        .WithMany("thuHocPhis")
                        .HasForeignKey("IdHinhThucThu")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Democheckbox.Model.HocSinh", "hocSinh")
                        .WithMany("thuHocPhis")
                        .HasForeignKey("IdHocSinh")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
