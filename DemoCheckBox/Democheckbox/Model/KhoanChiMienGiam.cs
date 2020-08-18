using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Democheckbox.Model
{
    public class KhoanChiMienGiam
    {
        [Key]
        public int Id { get; set; }
        public string TenKhoanChiMienGiam { get; set; }
        public int SoTienMienGiam { get; set; }
        public string GhiChu { get; set; }

        public KhoanChi khoanChi { get; set; }
        [ForeignKey("IdKhoanChi")]
        public int IdKhoanChi { get; set; }
    }
}
