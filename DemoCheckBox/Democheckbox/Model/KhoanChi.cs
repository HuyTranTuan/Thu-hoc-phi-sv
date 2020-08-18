using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Democheckbox.Model
{
    public class KhoanChi
    {
        [Key]
        public int Id { get; set; }
        public string TenKhoanChi { get; set; }
        public int ThuTu { get; set; }
        public bool SuDung { get; set; }

        public LoaiKhoanChi loaiKhoanChi { get; set; }
        [ForeignKey("IdLoaiKhoanChi")]
        public int IdLoaiKhoanChi { get; set; }

        [ForeignKey("IdKhoanChi")]
        public ICollection<KhoanChiMienGiam> khoanChiMienGiams { get; set; }
    }
}
