using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Democheckbox.Model
{
    public class DangKyDichVu
    {
        [Key]
        public int Id { get; set; }
        public string DonViTinh { get; set; }
        public int SoLuong { get; set; }
        public string GhiChu { get; set; }

        public KhoanThuDichVu khoanThuDichVu { get; set; }
        [ForeignKey("IdKhoanThuDichVu")]
        public int IdKhoanThuDichVu { get; set; }
        public DotThu dotThu { get; set; }
        [ForeignKey("IdDotThu")]
        public int IdDotThu { get; set; }
        public HocSinh hocSinh { get; set; }
        [ForeignKey("IdHocSinh")]
        public int IdHocSinh { get; set; }
    }
}
