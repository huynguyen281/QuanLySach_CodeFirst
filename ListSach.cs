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
using QLSach.BLL;
using System.Runtime.InteropServices;

namespace QLSach
{
    public partial class ListSach : Form
    {
        private MessageBoxButtons msb_Button = MessageBoxButtons.OK;
        private MessageBoxIcon msb_Icon = MessageBoxIcon.Information;

        public ListSach()
        {
            InitializeComponent();
            load_ComboBox();
        }

        #region SET UP FORM
        //Set drag form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void panelHeader_MouseDown_1(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        //Set close form and mnumuze form button
        private void minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region LOAD or RELOAD DATA
        public void load_ComboBox()
        {
            cbb_Authors.Items.Add(new Author() { ID_TacGia = 0, TenTacGia = "-Tất cả" });
            cbb_Authors.Items.AddRange(BLL.BLL.Instance.get_AllAuthors().ToArray());
            cbb_Authors.Text = "-Tất cả";
        }

        public void show_AllBooksToDGV()
        {
            dgv_DSSach.DataSource = BLL.BLL.Instance.get_AllBooksView();
            dgv_DSSach.Columns["MaSach"].Visible = false;
        }

        public void show_ListBooksViewToDGV(List<Book_View> list_Books)
        {
            dgv_DSSach.DataSource = null;
            dgv_DSSach.DataSource = list_Books;
            dgv_DSSach.Columns["MaSach"].Visible = false;
        }
        
        public void editBook_UpdateDGV(Book book)
        {
            if (BLL.BLL.Instance.update_Book(book))
            {
                Book_View book_view = BLL.BLL.Instance.get_BookView(book);
                if (dgv_DSSach.Rows == null || dgv_DSSach.Rows.Count <= 0) return;
                foreach (DataGridViewRow dr in dgv_DSSach.Rows)
                {
                    if (dr.Cells["MaSach"].Value.ToString() == book.MaSach)
                    {
                        dr.Cells["TenSach"].Value = book_view.TenSach;
                        dr.Cells["TacGia"].Value = book_view.TacGia;
                        dr.Cells["TinhTrang"].Value = book_view.TinhTrang;
                        dr.Cells["NXB"].Value = book_view.NXB;
                    }
                }
            }
        }

        public void addBook_UpdateDGV(Book book)
        {
            if (BLL.BLL.Instance.add_Book(book))
            {
                List<string> new_list_IdBook = new List<string>();
                if (dgv_DSSach.Rows != null || dgv_DSSach.Rows.Count > 0)
                {
                    foreach (DataGridViewRow dr in dgv_DSSach.Rows)
                    {
                        new_list_IdBook.Add(dr.Cells["MaSach"].Value.ToString());
                    }
                } 
                new_list_IdBook.Add(book.MaSach);

                show_ListBooksViewToDGV(BLL.BLL.Instance.get_ListBooksViewWithListId(new_list_IdBook));
            }
        }
        
        public void deleteBook_UpdateDGV(string ID_Book)
        {
            List<string> new_list_IdBook = new List<string>();
            if (dgv_DSSach.Rows == null || dgv_DSSach.Rows.Count <= 0) return;

            foreach (DataGridViewRow dr in dgv_DSSach.Rows)
            {
                new_list_IdBook.Add(dr.Cells["MaSach"].Value.ToString());
            }
            new_list_IdBook.Remove(ID_Book);
            show_ListBooksViewToDGV(BLL.BLL.Instance.get_ListBooksViewWithListId(new_list_IdBook));
        }
        #endregion

        #region SET UP EVENT/ACTION
        private void cbb_Authors_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbb_Authors.SelectedIndex == -1 || ((Author)cbb_Authors.SelectedItem).ID_TacGia == 0)
            {
                show_AllBooksToDGV();
            }
            else
            {
                show_ListBooksViewToDGV(BLL.BLL.Instance.get_ListBooksViewWithIdAuthor(((Author)cbb_Authors.SelectedItem).ID_TacGia));
            }
        }
        
        private void btn_Add_Click(object sender, EventArgs e)
        {
            DetailSach f_D = new DetailSach();
            f_D.Show();
            f_D.add += new DetailSach.Del(addBook_UpdateDGV);
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            if (dgv_DSSach.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn sách cần chỉnh sửa", "Thông báo", msb_Button, msb_Icon);
                return;
            }
            Book edit_book = BLL.BLL.Instance.get_BookWithIdBook(dgv_DSSach.CurrentRow.Cells["MaSach"].Value.ToString());
            DetailSach f_D = new DetailSach();
            f_D.Show();
            f_D.show_info(edit_book);
            f_D.edit += new DetailSach.Del(editBook_UpdateDGV);
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            string keyword = txt_Search.Text;
            if (txt_Search.Text == "")
            {
                MessageBox.Show("Vui lòng điền thông tin cần tìm kiếm", "Thông báo", msb_Button, msb_Icon);
            }
            else
            {
                List<string> list_IdBook = new List<string>();
                if (dgv_DSSach.Rows == null || dgv_DSSach.Rows.Count <= 0) return;

                foreach (DataGridViewRow dr in dgv_DSSach.Rows)
                {
                    list_IdBook.Add(dr.Cells["MaSach"].Value.ToString());
                }

                List<Book_View> list_BooksView = BLL.BLL.Instance.get_ListBooksViewWithKeyWord(keyword, list_IdBook);
                if (list_BooksView == null || list_BooksView.Count <= 0) MessageBox.Show("Có không kết quả", "Thông báo", msb_Button, msb_Icon);
                else show_ListBooksViewToDGV(list_BooksView);
            }    
        }

        private void btn_Del_Click(object sender, EventArgs e)
        {
            if (dgv_DSSach.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn sách cần chỉnh sửa", "Thông báo", msb_Button, msb_Icon);
                return;
            }
            else
            {
                string id_Book = dgv_DSSach.CurrentRow.Cells["MaSach"].Value.ToString();
                if (BLL.BLL.Instance.delete_Book(id_Book))
                {
                    MessageBox.Show("Xoá thành công rồi đấy!", "Thông báo", msb_Button, msb_Icon);
                }
                deleteBook_UpdateDGV(id_Book);
            }
        }

        private void btn_Sort_Click(object sender, EventArgs e)
        {
            if (cbb_Sort.SelectedIndex == -1)
            {
                MessageBox.Show("Chưa chọn kiểu sắp xếp !", "Thông báo !", msb_Button, msb_Icon);
                return;
            }
            if (dgv_DSSach.Rows == null || dgv_DSSach.Rows.Count <= 0) return;
            
            List<string> list_IdBook = new List<string>();
            foreach (DataGridViewRow dr in dgv_DSSach.Rows)
            {
                list_IdBook.Add(dr.Cells["MaSach"].Value.ToString());
            }
            
            if (cbb_Sort.SelectedIndex == 0)
            {
                dgv_DSSach.DataSource = BLL.BLL.Instance.Sort(
                    BLL.BLL.Instance.get_ListBooksViewWithListId(list_IdBook).ToArray(), Book_View.CompareName).ToList();
            }
            else
            {
                dgv_DSSach.DataSource = BLL.BLL.Instance.Sort(
                    BLL.BLL.Instance.get_ListBooksViewWithListId(list_IdBook).ToArray(), Book_View.CompareDate).ToList();
            }
        }
        #endregion

    }
}
