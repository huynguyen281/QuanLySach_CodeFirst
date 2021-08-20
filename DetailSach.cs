using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLSach.DTO;

namespace QLSach
{
    public partial class DetailSach : Form
    {
        public delegate void Del(Book s);
        public Del edit { get; set; }
        public Del add { get; set; }
        public Del show_info { get; set; }
        public DetailSach()
        {
            InitializeComponent();
            set_ComboBox();
            show_info += new Del(show_BookInfo);
            this.add = null;
            this.edit = null;
        }

        #region SET UP FORM
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panelHeader_MouseDown_1(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        #endregion

        #region LOAD DATA
        private void DetailSach_Load(object sender, EventArgs e)
        {
            
        }

        public void set_ComboBox()
        {
            cbb_Authors.Items.AddRange(BLL.BLL.Instance.get_AllAuthors().ToArray());
        }

        public void show_BookInfo(Book s)
        {
            txt_MS.Text = s.MaSach;
            txt_Name.Text = s.TenSach;
            dtp_NXB.Value = s.NXB;
            if (s.TinhTrang == true) rb_Con.Checked = true;
            else rb_Het.Checked = true;
            cbb_Authors.SelectedItem = s.TG;
            txt_MS.Enabled = false;
        }
        #endregion

        #region SET EVENT
        private void btn_OK_Click(object sender, EventArgs e)
        {
            Book s = new Book()
            {
                MaSach = txt_MS.Text,
                TenSach = txt_Name.Text,
                NXB = dtp_NXB.Value.Date,
                TinhTrang = rb_Con.Checked == true ? true : false,
                TG = (Author)cbb_Authors.SelectedItem
            };

            if (cbb_Authors.SelectedIndex == -1)
            {
                MessageBox.Show("Chưa chọn tác giả kìa ba !");
                return;
            }
            //addd
            if (add != null)
            {
                if (BLL.BLL.Instance.is_EsxitIdBook(s.MaSach))
                {
                    MessageBox.Show("Mã sách đã tồn tại !");
                    return;
                }
                add(s);
            }
            //edit
            if (edit != null)
            {
                edit(s);
            }
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

    }
}
