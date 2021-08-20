using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLSach.DTO;

namespace QLSach.BLL
{
    
    public class BLL
    {
        private QLSach QLSach;
        private static BLL _Instance;
        private BLL()
        {
            QLSach = new QLSach();
        }
        public static BLL Instance { 
            get
            {
                if (_Instance == null) _Instance = new BLL();
                return _Instance;
            }
            private set => _Instance = value; 
        }

        #region GET_DATA
        public Book_View get_BookView(Book book)
        {
            return new Book_View()
            {
                MaSach = book.MaSach,
                TenSach = book.TenSach,
                TacGia = book.TG.TenTacGia,
                TinhTrang = book.TinhTrang,
                NXB = book.NXB
            };
        }
        public Book get_BookWithIdBook(string IdBook)
        {
            return QLSach.Sachs.Find(IdBook);
        }
        public Author get_AuthorWithIDAuthor(int IdAuthor)
        {
            return QLSach.TacGias.Find(IdAuthor);
        }
        public List<Book> get_AllBooks()
        {
            return QLSach.Sachs.ToList();
        }
        public List<Book_View> get_AllBooksView()
        {
            List<Book> list_Books = get_AllBooks();
            List<Book_View> list_BooksView = new List<Book_View>();
            if (list_Books != null)
            {
                foreach (Book book in list_Books)
                {
                    list_BooksView.Add(get_BookView(book));
                }
            }
            return list_BooksView;
        }
        public List<Book_View> get_ListBooksViewWithIdAuthor(int IdAuthors)
        {
            List<Book> list_Books = get_AllBooks();
            List<Book_View> list_BooksView = new List<Book_View>();
            if (list_Books != null)
            {
                foreach (Book book in list_Books)
                {
                    if (book.TG.ID_TacGia == IdAuthors)
                    {
                        list_BooksView.Add(get_BookView(book));
                    }
                }
            }
            return list_BooksView;
        }
        public List<Book_View> get_ListBooksViewWithKeyWord(string keyword, List<string> list_IdBook)
        {
            List<Book_View> list_BooksView = get_ListBooksViewWithListId(list_IdBook);
            List<Book_View> new_list_BooksView = new List<Book_View>();
            foreach (Book_View bv in list_BooksView)
            {
                if (bv.TenSach.ToUpper().Contains(keyword.ToUpper()))
                {
                    new_list_BooksView.Add(bv);
                }
                else if (bv.TacGia.ToUpper().Contains(keyword.ToUpper()))
                {
                    new_list_BooksView.Add(bv);
                }
                else if (bv.NXB.ToString().Contains(keyword))
                {
                    new_list_BooksView.Add(bv);
                }
                else if (bv.TinhTrang == true && keyword.ToUpper().Contains("còn hàng"))
                {
                    new_list_BooksView.Add(bv);
                }
                else if (bv.TinhTrang == false && keyword.ToUpper().Contains("hết hàng"))
                {
                    new_list_BooksView.Add(bv);
                }
            }
            return new_list_BooksView;
        }
        public List<Book_View> get_ListBooksViewWithListId(List<string> list_IdBook)
        {
            List<Book_View> list_BooksView = new List<Book_View>();
            foreach(string id in list_IdBook)
            {
                list_BooksView.Add(get_BookView(QLSach.Sachs.Find(id)));
            }
            return list_BooksView;
        }
        public List<Author> get_AllAuthors()
        {
            return QLSach.TacGias.ToList();
        } 
        #endregion

        #region BOOL_FUNCTION
        public bool is_EsxitIdBook(string IdBook)
        {
            Book book = QLSach.Sachs.Find(IdBook);
            if (book != null) return true;
            else return false;  
        }
        
        public bool update_Book(Book book)
        {
            Book book_edit = QLSach.Sachs.Find(book.MaSach);
            book_edit.TenSach = book.TenSach;
            book_edit.NXB = book.NXB;
            book_edit.TinhTrang = book.TinhTrang;
            book_edit.TG = book.TG;
            QLSach.SaveChanges();
            return true;
        }
        public bool add_Book(Book book)
        {
            QLSach.Sachs.Add(book);
            QLSach.SaveChanges();
            return true;
        }
        public bool delete_Book(string id_Book)
        {
            Book b = QLSach.Sachs.Find(id_Book);
            QLSach.Sachs.Remove(b);
            QLSach.SaveChanges();
            return true;
        }
        #endregion

        public delegate bool Compare(object o1, object o2);
        public object[] Sort(object[] arr, Compare cmp)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (cmp(arr[i], arr[j]))
                    {
                        object temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
            return arr;
        }
    }
}
