using Democheckbox.Domain;
using Democheckbox.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Democheckbox
{
    public class UserProfileDbContext : DbContext
    {
        public virtual DbSet<UserProfile> UserProfiles { get; set; }
        public virtual DbSet<HocSinh> HocSinhs { get; set; }
        public virtual DbSet<Lop> Lops { get; set; }
        public virtual DbSet<Khoi> Khois { get; set; }
        public virtual DbSet<LoaiHinhThucThu> LoaiHinhThucThus { get; set; }
        public virtual DbSet<HinhThucThu> HinhThucThus { get; set; }
        public virtual DbSet<LoaiKhoanChi> LoaiKhoanChis { get; set; }
        public virtual DbSet<KhoanChi> KhoanChis { get; set; }
        public virtual DbSet<LoaiSanPham> LoaiSanPhams { get; set; }
        public virtual DbSet<TinhChatKhoanThu> TinhChatKhoanThus { get; set; }
        public virtual DbSet<ThuHocPhi> ThuHocPhis { get; set; }
        public virtual DbSet<PhieuThu> PhieuThus { get; set; }
        public virtual DbSet<NguoiThu> NguoiThus { get; set; }
        public virtual DbSet<LoaiKhoanThu> LoaiKhoanThus { get; set; }
        public virtual DbSet<KhoanThuDichVu> KhoanThuDichVus { get; set; }
        public virtual DbSet<KhoanThuCoDinh> KhoanThuCoDinhs { get; set; }
        public virtual DbSet<KhoanThuBanHang> KhoanThuBanHangs { get; set; }
        public virtual DbSet<KhoanChiMienGiam> KhoanChiMienGiams { get; set; }
        public virtual DbSet<KeHoachThu> KeHoachThus { get; set; }
        public virtual DbSet<HocKy> HocKies { get; set; }
        public virtual DbSet<DotThu> DotThus { get; set; }
        public virtual DbSet<DangKyDichVu> DangKyDichVus { get; set; }
        public virtual DbSet<ChiTietPhieuThu> ChiTietPhieuThus { get; set; }
        public virtual DbSet<BaoCaoDangKyDichVu> BaoCaoDangKyDichVus { get; set; }
        public virtual DbSet<BaoCaoCongNo> BaoCaoCongNos { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseSqlServer("Server=DESKTOP-GAP3GBT\\HUYDEPTRAINEW;Database=DemoCreateTim; ;user id=sa;password=123456;MultipleActiveResultSets=true");
            optionsBuilder.UseSqlServer("Server=DESKTOP-GAP3GBT\\HUYDEPTRAINEW;Database=Thuhocphi; ;user id=sa;password=123456;MultipleActiveResultSets=true");
        }
    }
}
