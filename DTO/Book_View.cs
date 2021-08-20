using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSach.DTO
{
    public class Book_View
    {
        public string MaSach { get; set; }
        public string TenSach { get; set; }
        public string TacGia { get; set; }
        public bool TinhTrang { get; set; }
        public DateTime NXB { get; set; }

        public static Boolean CompareName(object book1, object book2) //nếu kí tự đầu tiên trong tên book1 lớn hơn thì trả về true (theo alpha b)
        {
            return String.Compare(((Book_View)book1).TenSach, ((Book_View)book2).TenSach) > 0 ? true : false;
        }
        public static Boolean CompareDate(object book1, object book2) //nếu book1 xuất bản trước thì trả về true
        {
            return ((Book_View)book1).NXB < ((Book_View)book2).NXB ? true : false;
        }
    }
}
