using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Democheckbox.Model
{
    public class HocSinh
    {
        [Key]
        public int Id { get; set; }
        public string TenHocSinh { get; set; }
        public DateTime NgaySinh { get; set; }
        public string GioiTinh { get; set; }


        public Lop lop { get; set; }
        [ForeignKey("IdLop")]
        public int IdLop { get; set; }

        [ForeignKey("IdHocSinh")]
        public ICollection<ThuHocPhi> thuHocPhis { get; set; }

        [ForeignKey("IdHocSinh")]
        public ICollection<BaoCaoCongNo> baoCaoCongNos { get; set; }

        [ForeignKey("IdHocSinh")]
        public ICollection<BaoCaoDangKyDichVu> baoCaoDangKyDichVus { get; set; }

        [ForeignKey("IdHocSinh")]
        public ICollection<ChiTietPhieuThu> chiTietPhieuThus { get; set; }

        [ForeignKey("IdHocSinh")]
        public ICollection<DangKyDichVu> dangKyDichVus { get; set; }
    }
}
