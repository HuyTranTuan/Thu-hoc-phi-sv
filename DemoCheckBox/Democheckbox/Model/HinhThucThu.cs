using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Democheckbox.Model
{
    public class HinhThucThu
    {
        [Key]
        public int Id { get; set; }
        public string TenHinhThucThu { get; set; }

        public LoaiHinhThucThu loaiHinhThucThu { get; set; }
        [ForeignKey("IdLoaiHinhThucThu")]
        public int IdLoaiHinhThucThu { get; set; }

        [ForeignKey("IdHinhThucThu")]
        public ICollection<KeHoachThu> keHoachThus { get; set; }

        [ForeignKey("IdHinhThucThu")]
        public ICollection<ThuHocPhi> thuHocPhis { get; set; }
    }
}
