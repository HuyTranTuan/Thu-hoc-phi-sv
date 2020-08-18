using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Democheckbox.Model
{
    public class HocKy
    {
        [Key]
        public int Id { get; set; }
        public string TenHocKy { get; set; }

        [ForeignKey("IdHocKy")]
        public ICollection<KeHoachThu> keHoachThus { get; set; }
    }
}
