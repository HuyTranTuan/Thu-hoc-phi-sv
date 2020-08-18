using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Democheckbox.Dto
{
    public class KhoanChiDTO
    {
        public int Id { get; set; }
        public string TenKhoanChi { get; set; }
        public int ThuTu { get; set; }
        public bool SuDung { get; set; }
        public int IdLoaiKhoanChi { get; set; }
    }
}
