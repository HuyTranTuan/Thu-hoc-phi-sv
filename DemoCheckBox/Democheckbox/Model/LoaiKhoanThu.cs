using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Democheckbox.Model
{
    public class LoaiKhoanThu
    {
        [Key]
        public int Id { get; set; }
        public string TenLoaiKhoanThu { get; set; }
        public bool SuDung { get; set; }
        public int ThuTu { get; set; }

        public TinhChatKhoanThu tinhChatKhoanThu { get; set; }
        [ForeignKey("IdTinhChatKhoanThu")]
        public int IdTinhChatKhoanThu { get; set; }

        [ForeignKey("IdLoaiKhoanThu")]
        public ICollection<KhoanThuCoDinh> khoanThuCoDinhs { get; set; }

        [ForeignKey("IdLoaiKhoanThu")]
        public ICollection<KhoanThuDichVu> khoanThuDichVus { get; set; }

        [ForeignKey("IdLoaiKhoanThu")]
        public ICollection<KhoanThuBanHang> khoanThuBanHangs { get; set; }
    }
}
