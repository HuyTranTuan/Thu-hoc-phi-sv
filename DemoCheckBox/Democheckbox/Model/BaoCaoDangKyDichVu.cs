using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Democheckbox.Model
{
    public class BaoCaoDangKyDichVu
    {
        [Key]
        public int Id { get; set; }
        public int DonGia { get; set; }
        public int SoLuong { get; set; }
        public int ThanhTien { get; set; }

        public HocSinh hocSinh { get; set; }
        [ForeignKey("IdHocSinh")]
        public int IdHocSinh { get; set; }

        public KhoanThuDichVu khoanThuDichVu { get; set; }
        [ForeignKey("IdKhoanThuDichVu")]
        public int IdKhoanThuDichVu { get; set; }
    }
}
