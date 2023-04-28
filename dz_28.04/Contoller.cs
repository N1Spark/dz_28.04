using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dz_28._04.Model;
using System.Windows.Forms;

namespace dz_28._04
{
    class Controller
    {
        Database db;
        Print print;
        public Controller()
        {
            db = new Database();
        }
        public string GetBook(string bookname)
        {
            Book rez = db.Find(bookname);

            if (rez != null)
            {
                return rez.ToString();
            }
            return "Книга не найдена!";
        }

        public void NewBook()
        {
            Add add = new Add();
            Book book = null;
            DialogResult rez = add.ShowDialog();
            if (rez == DialogResult.OK)
            {
                book = add.GetNewBook();
                if (book == null)
                {
                    MessageBox.Show("Null");
                    return;
                }
            }
            else if (rez == DialogResult.Cancel)
            {
                return;
            }
            db.AddBook(book);
            GetAllBooks();
        }

        public void GetAllBooks()
        {
            print = new Print();
            db.controller = this;
            db.ShowAllBooks();
        }
        public void ShowAllBooks(List<Book> books)
        {
            print.Show();
            foreach (Book x in books)
                print.AddBook(x);
        }
    }
}
