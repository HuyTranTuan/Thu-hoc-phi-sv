using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Democheckbox.Model
{
    public class Lop
    {
        [Key]
        public int Id { get; set; }
        public string TenLop { get; set; }


        public Khoi khoi { get; set; }
        [ForeignKey("IdKhoi")]
        public int IdKhoi { get; set; }

        [ForeignKey("IdLop")]
        public ICollection<HocSinh> hocSinhs { get; set; }
    }
}
