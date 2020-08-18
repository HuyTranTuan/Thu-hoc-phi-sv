using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Democheckbox.Dto
{
    public class HocSinhDTO
    {
        public int Id { get; set; }
        public string TenHocSinh { get; set; }
        public DateTime NgaySinh { get; set; }
        public string GioiTinh { get; set; }
        public int IdLop { get; set; }
    }
}
