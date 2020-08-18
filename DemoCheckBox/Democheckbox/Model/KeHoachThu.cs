using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Democheckbox.Model
{
    public class KeHoachThu
    {
        [Key]
        public int Id { get; set; }
        public int SoTien { get; set; }
        public string GhiChu { get; set; }
        public int SoLuongHocSinh { get; set; }
        public bool BatBuoc { get; set; }


        public HocKy hocKy { get; set; }
        [ForeignKey("IdHocKy")]
        public int IdHocKy { get; set; }

        public Khoi khoi { get; set; }
        [ForeignKey("IdKhoi")]
        public int IdKhoi { get; set; }

        public HinhThucThu hinhThucThu { get; set; }
        [ForeignKey("IdHinhThucThu")]
        public int IdHinhThucThu { get; set; }

        public KhoanThuCoDinh khoanThuCoDinh { get; set; }
        [ForeignKey("IdKhoanThuCoDinh")]
        public int IdKhoanThuCoDinh { get; set; }
    }
}
