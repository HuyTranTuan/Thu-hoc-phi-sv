using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Democheckbox.Dto
{
    public class KhoanThuCoDinhDTO
    {
        public int Id { get; set; }
        public string TenKhoanThuCoDinh { get; set; }
        public int DonGia { get; set; }
        public int ThuTu { get; set; }
        public string GhiChu { get; set; }
        public bool SuDung { get; set; }
        public int IdLoaiKhoanThu { get; set; }
    }
}
