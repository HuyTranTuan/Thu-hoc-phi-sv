using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Democheckbox.Model
{
    public class TinhChatKhoanThu
    {
        [Key]
        public int Id { get; set; }
        public string TenTinhChatKhoanThu { get; set; }

        [ForeignKey("IdTinhChatKhoanThu")]
        public ICollection<LoaiKhoanThu> loaiKhoanThus { get; set; }
    }
}
