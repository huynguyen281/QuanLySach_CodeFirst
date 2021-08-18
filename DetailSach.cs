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
    public partial class DetailSach : Form
    {
        public delegate void Del(Sach s);
        public Del edit { get; set; }
        public Del show_info { get; set; }
        public DetailSach()
        {
            InitializeComponent();
            show_info += new Del(show);
        }

        public void show(Sach s)
        {
            txt_MS.Text = s.MaSach;
            txt_Name.Text = s.TenSach;
            dtp_NXB.Value = s.NXB;
            rb_Con.Checked = s.TinhTrang == true ? true : false;
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            Sach s = new Sach()
            {
                MaSach = txt_MS.Text,
                TenSach = txt_Name.Text,
                NXB = dtp_NXB.Value.Date,
                TinhTrang = rb_Con.Checked == true ? true : false
            };

            if (edit != null)
            {
                edit(s);
            }
        }
    }
}
