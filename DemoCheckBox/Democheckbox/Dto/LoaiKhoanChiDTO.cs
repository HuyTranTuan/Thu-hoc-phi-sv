using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Democheckbox.Dto
{
    public class LoaiKhoanChiDTO
    {
        public int Id { get; set; }
        public string TenLoaiKhoanChi { get; set; }
        public int ThuTu { get; set; }
        public bool SuDung { get; set; }
    }
}
