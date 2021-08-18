using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLSach.DTO;

namespace QLSach
{
    class CreateTable : CreateDatabaseIfNotExists<QLSach>
    //DropCreateDatabaseIfModelChanges<QLSV>
    //DropCreateDatabaseAlways<QLSV>
    {
        protected override void Seed(QLSach context)
        {
            context.Sachs.AddRange(new Sach[] {
                new Sach(){MaSach = "101", TenSach = "Tôi thấy hoa vàng trên có xanh", NXB = new DateTime(2000,5,6), TinhTrang = true, ID_TG = 1},
                new Sach(){MaSach = "102", TenSach = "Mắt biết", NXB = new DateTime(2000,4,6), TinhTrang = true, ID_TG = 1},
                new Sach(){MaSach = "103", TenSach = "Kí sự code dạo", NXB = new DateTime(2003,5,8), TinhTrang = true, ID_TG = 2}
            });

            context.TacGias.AddRange(new TacGia[]
            {
                new TacGia(){ ID_TacGia = 1, TenTacGia = "Nguyễn Nhật Ánh"},
                new TacGia(){ ID_TacGia = 2, TenTacGia = "abc"}
            });
        }
    }
}
