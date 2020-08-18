using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Democheckbox.Model
{
    public class KhoanThuCoDinh
    {
        [Key]
        public int Id { get; set; }
        public string TenKhoanThuCoDinh { get; set; }
        public int DonGia { get; set; }
        public int ThuTu { get; set; }
        public string GhiChu { get; set; }
        public bool SuDung { get; set; }


        public LoaiKhoanThu loaiKhoanThu { get; set; }
        [ForeignKey("IdLoaiKhoanThu")]
        public int IdLoaiKhoanThu { get; set; }

        [ForeignKey("IdKhoanThuCoDinh")]
        public ICollection<KeHoachThu> keHoachThus { get; set; }
    }
}
