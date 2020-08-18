using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Democheckbox.Model
{
    public class Khoi
    {
        [Key]
        public int Id { get; set; }
        public string TenKhoi { get; set; }

        [ForeignKey("IdKhoi")]
        public ICollection<Lop> lops { get; set; }

        [ForeignKey("IdKhoi")]
        public ICollection<KeHoachThu> keHoachThus { get; set; }
    }
}
