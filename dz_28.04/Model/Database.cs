using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dz_28._04.Model
{
    class Database
    {
        List<Book> books = new List<Book>();
        public Controller controller;
        public Database()
        {
            books.Add(new Book("CLR via C#", "Jefry Richter"));
            books.Add(new Book("Эмоциональный интеллект", "Дэниел Гоулман"));
            books.Add(new Book("С++", "Бьярне Страуструп"));
            books.Add(new Book("Триз", "Марк"));
        }
        public Book Find(string bookName)
        {
            foreach (Book f in books)
            {
                if (f.Name == bookName)
                {
                    return f;
                }
            }
            return null;
        }

        public void AddBook(Book book)
        {
            if (!books.Contains(book))
            {
                books.Add(book);
                MessageBox.Show("книга добавлена в бд !!!");
                return;
            }
            MessageBox.Show("книга найдена");
        }
        public void ShowAllBooks()
        {
            controller.ShowAllBooks(books);
        }
    }
}
