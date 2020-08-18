using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Democheckbox.Model
{
    public class LoaiKhoanChi
    {
        [Key]
        public int Id { get; set; }
        public string TenLoaiKhoanChi { get; set; }
        public int ThuTu { get; set; }
        public bool SuDung { get; set; }

        [ForeignKey("IdLoaiKhoanChi")]
        public ICollection<KhoanChi> khoanChis { get; set; }

    }
}
