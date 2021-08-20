using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSach.DTO
{
    [Table("TacGia")]
    public class Author
    {
        public Author()
        {
            Sachs = new HashSet<Book>();
        }

        [Key]
        public int ID_TacGia { get; set; }
        public string TenTacGia { get; set; }

        public virtual ICollection<Book> Sachs { get; set; }

        public override string ToString()
        {
            return this.TenTacGia;
        }
    }
}
