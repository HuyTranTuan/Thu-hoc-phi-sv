using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Democheckbox.Model
{
    public class PhieuThu
    {
        [Key]
        public int Id { get; set; }
        public DateTime NgayThu { get; set; }
        public int TongTien { get; set; }

        public NguoiThu nguoiThu { get; set; }
        [ForeignKey("IdNguoiThu")]
        public int IdNguoiThu { get; set; }

        public ChiTietPhieuThu chiTietPhieuThu { get; set; }
        [ForeignKey("IdChiTietPhieuThu")]
        public int IdChiTietPhieuThu { get; set; }
    }
}
