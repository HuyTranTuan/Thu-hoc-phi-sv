using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Democheckbox.Model
{
    public class DotThu
    {
        [Key]
        public int Id { get; set; }
        public string TenDotThu { get; set; }

        [ForeignKey("IdDotThu")]
        public ICollection<DangKyDichVu> dangKyDichVus { get; set; }

    }
}
