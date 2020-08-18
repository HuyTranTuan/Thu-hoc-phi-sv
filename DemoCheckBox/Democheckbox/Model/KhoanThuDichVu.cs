using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Democheckbox.Model
{
    public class KhoanThuDichVu
    {
        [Key]
        public int Id { get; set; }
        public string TenKhoanThuDichVu { get; set; }
        public int DonGia { get; set; }
        public int ThuTu { get; set; }
        public int DonGiaTra { get; set; }
        public string GhiChu { get; set; }
        public bool SuDung { get; set; }
        public bool TinhTheoNgay { get; set; }
        public bool TraLaiKhiVang { get; set; }

        public LoaiKhoanThu loaiKhoanThu { get; set; }
        [ForeignKey("IdLoaiKhoanThu")]
        public int IdLoaiKhoanThu { get; set; }

        [ForeignKey("IdKhoanThuDichVu")]
        public ICollection<DangKyDichVu> dangKyDichVus { get; set; }

        [ForeignKey("IdKhoanThuDichVu")]
        public ICollection<BaoCaoDangKyDichVu> baoCaoDangKyDichVus { get; set; }
    }
}
