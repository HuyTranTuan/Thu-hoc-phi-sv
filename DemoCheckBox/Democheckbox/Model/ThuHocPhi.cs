using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Democheckbox.Model
{
    public class ThuHocPhi
    {
        [Key]
        public int Id { get; set; }
        public int IdKhoanThuCoDinh { get; set; }
        public int SoLuong1 { get; set; }
        public int IdKhoanThuDichVu { get; set; }
        public int SoLuong2 { get; set; }
        public int IdKhoanThuBanHang { get; set; }
        public int SoLuong3 { get; set; }
        public int IdHocKy { get; set; }
        public int IdKhoanChiMienGiam { get; set; }
        public int IdNguoiThu { get; set; }
        public DateTime NgayThu { get; set; }

        public HocSinh hocSinh { get; set; }
        [ForeignKey("IdHocSinh")]
        public int IdHocSinh { get; set; }

        public HinhThucThu hinhThucThu { get; set; }
        [ForeignKey("IdHinhThucThu")]
        public int IdHinhThucThu { get; set; }
    }
}
