using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Democheckbox.Dto
{
    public class LoaiKhoanThuDTO
    {
        public int Id { get; set; }
        public string TenLoaiKhoanThu { get; set; }
        public int IdTinhChatKhoanThu { get; set; }
        public bool SuDung { get; set; }
        public int ThuTu { get; set; }
    }
}
