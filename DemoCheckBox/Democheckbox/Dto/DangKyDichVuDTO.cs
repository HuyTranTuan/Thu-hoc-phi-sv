using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Democheckbox.Dto
{
    public class DangKyDichVuDTO
    {
        public int Id { get; set; }
        public string DonViTinh { get; set; }
        public int SoLuong { get; set; }
        public string GhiChu { get; set; }
        public int IdHocSinh { get; set; }
        public int IdKhoanThuDichVu { get; set; }
        public int IdDotThu { get; set; }
    }
}
