using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Democheckbox.Model
{
    public class ChiTietPhieuThu
    {
        [Key]
        public int Id { get; set; }
        public int TongTien { get; set; }
        public int KhauTru { get; set; }
        public int DaThu { get; set; }
        public string SoTienBangChu { get; set; }

        public HocSinh hocSinh { get; set; }
        [ForeignKey("IdHocSinh")]
        public int IdHocSinh { get; set; }

        [ForeignKey("IdChiTietPhieuThu")]
        public ICollection<PhieuThu> phieuThus { get; set; }
    }
}
