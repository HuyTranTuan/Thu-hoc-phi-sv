using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Democheckbox.Model
{
    public class LoaiSanPham
    {
        [Key]
        public int Id { get; set; }
        public string TenLoaiSanPham { get; set; }

        [ForeignKey("IdLoaiSanPham")]
        public ICollection<KhoanThuBanHang> khoanThuBanHangs { get; set; }
    }
}
