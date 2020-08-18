using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Democheckbox.Dto
{
    public class KeHoachThuDTO
    {
        public int Id { get; set; }
        public int SoTien { get; set; }
        public string GhiChu { get; set; }
        public int SoLuongHocSinh { get; set; }
        public bool BatBuoc { get; set; }
        public int IdHocKy { get; set; }
        public int IdKhoi { get; set; }
        public int IdHinhThucThu { get; set; }
        public int IdKhoanThuCoDinh { get; set; }
    }
}
