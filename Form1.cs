using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLSach.DTO;

namespace QLSach
{
    public partial class Form1 : Form
    {
        private QLSach QLSach = new QLSach();
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Show_Click(object sender, EventArgs e)
        {
            //dgv_DSSach.DataSource = null;
            dgv_DSSach.DataSource = QLSach.Sachs.ToList();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            QLSach.Sachs.Add(new Sach()
            {
                MaSach = "104",
                TenSach = "BCD",
                NXB = DateTime.Now,
                TinhTrang = false,
                ID_TG = 1
            });
            QLSach.SaveChanges();
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            Sach sach_edit = (Sach)dgv_DSSach.CurrentRow.DataBoundItem;
            DetailSach f_D = new DetailSach();
            f_D.show_info(sach_edit);
            f_D.edit += new DetailSach.Del(Update_DGV);
            f_D.Show();
        }

        public void Update_DGV(Sach s)
        {
            Sach sa = QLSach.Sachs.Find(s.MaSach);
            sa.TenSach = s.TenSach;
            sa.NXB = s.NXB;
            sa.TG = s.TG;
            sa.TinhTrang = s.TinhTrang;
            QLSach.SaveChanges();

            dgv_DSSach.DataSource = QLSach.Sachs.ToList();


            //List<Sach> new_ListSach = new List<Sach>();
            //foreach (Sach sach in (List<Sach>)dgv_DSSach.DataSource)
            //{
            //    if (sach.MaSach == s.MaSach)
            //    {
            //        new_ListSach.Add(s);
            //    }
            //    else
            //    {
            //        new_ListSach.Add(sach);
            //    }
            //}
            //dgv_DSSach.DataSource = new_ListSach;
        }
    }
}
