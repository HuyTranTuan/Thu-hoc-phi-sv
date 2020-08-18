using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Democheckbox.Model
{
    public class NguoiThu
    {
        [Key]
        public int Id { get; set; }
        public string TenNguoiThu { get; set; }

        [ForeignKey("IdNguoiThu")]
        public ICollection<PhieuThu> phieuThus { get; set; }
    }
}
