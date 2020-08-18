using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Democheckbox.Dto
{
    public class KhoanThuDichVuDTO
    {
        public int Id { get; set; }
        public string TenKhoanThuDichVu { get; set; }
        public int DonGia { get; set; }
        public int ThuTu { get; set; }
        public int DonGiaTra { get; set; }
        public string GhiChu { get; set; }
        public bool SuDung { get; set; }
        public bool TinhTheoNgay { get; set; }
        public bool TraLaiKhiVang { get; set; }
        public int IdLoaiKhoanThu { get; set; }
    }
}
