using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Democheckbox.Dto
{
    public class KhoanThuBanHangDTO
    {
        public int Id { get; set; }
        public string TenSanPham { get; set; }
        public int DonGia { get; set; }
        public int ThuTu { get; set; }
        public bool SuDung { get; set; }
        public int IdLoaiKhoanThu { get; set; }
        public int IdLoaiSanPham { get; set; }
    }
}
