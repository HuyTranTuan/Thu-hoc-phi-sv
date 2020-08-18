using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Democheckbox.Dto
{
    public class PhieuThuDTO
    {
        public int Id { get; set; }
        public DateTime NgayThu { get; set; }
        public int TongTien { get; set; }
        public int IdNguoiThu { get; set; }
        public int IdChiTietPhieuThu { get; set; }
    }
}
