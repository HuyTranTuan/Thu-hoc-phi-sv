using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Democheckbox.Dto
{
    public class KhoanChiMienGiamDTO
    {
        public int Id { get; set; }
        public string TenKhoanChiMienGiam { get; set; }
        public int SoTienMienGiam { get; set; }
        public string GhiChu { get; set; }
        public int IdKhoanChi { get; set; }
    }
}
