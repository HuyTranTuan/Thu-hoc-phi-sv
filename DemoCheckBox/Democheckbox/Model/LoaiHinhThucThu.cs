using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Democheckbox.Model
{
    public class LoaiHinhThucThu
    {
        [Key]
        public int Id { get; set; }
        public string TenLoaiHinhThucThu { get; set; }

        [ForeignKey("IdLoaiHinhThucThu")]
        public ICollection<HinhThucThu> hinhThucThus { get; set; }
    }
}
