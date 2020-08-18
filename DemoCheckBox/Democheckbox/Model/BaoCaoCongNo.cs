using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Democheckbox.Model
{
    public class BaoCaoCongNo
    {
        [Key]
        public int Id { get; set; }
        public int CongNoHocPhi { get; set; }
        public int CongNoDichVu { get; set; }
        public int TongCongNo { get; set; }

        public HocSinh hocSinh { get; set; }
        [ForeignKey("IdHocSinh")]
        public int IdHocSinh { get; set; }
    }
}
