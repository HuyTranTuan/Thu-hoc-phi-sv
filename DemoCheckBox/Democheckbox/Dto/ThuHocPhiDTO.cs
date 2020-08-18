using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Democheckbox.Dto
{
    public class ThuHocPhiDTO
    {
        public int Id { get; set; }
        public int IdKhoanThuCoDinh { get; set; }
        public int SoLuong1 { get; set; }
        public int IdKhoanThuDichVu { get; set; }
        public int SoLuong2 { get; set; }
        public int IdKhoanThuBanHang { get; set; }
        public int SoLuong3 { get; set; }
        public int IdHocKy { get; set; }
        public int IdKhoanChiMienGiam { get; set; }
        public DateTime NgayThu { get; set; }
        public int IdNguoiThu { get; set; }
        public int IdHocSinh { get; set; }
        public int IdHinhThucThu { get; set; }
    }
}
