using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSach.DTO
{
    [Table("Sach")]
    public class Book
    {
        [Key]
        public string MaSach { get; set; }
        public string TenSach { get; set; }
        public DateTime NXB { get; set; }
        public bool TinhTrang { get; set; }
        public int ID_TG { get; set; }

        [ForeignKey("ID_TG")]
        public virtual Author TG { get; set; }
    }
}
