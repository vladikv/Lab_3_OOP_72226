using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3_OOP_72226
{
    public class Reader : Person
    {
        private List<Book> books = new List<Book>();

        public Reader(string fn, string ln, int age) : base(fn, ln, age)
        {
        }

        public void AddBook(Book b)
        {
            books.Add(b);
        }

        public void ViewBook()
        {
            Console.WriteLine("Przeczytane książki:");
            foreach (var b in books)
                Console.WriteLine(" - " + b.Title);
        }

        public override void View()
        {
            base.View();
            ViewBook();
        }

        protected List<Book> Books => books;
    }

}
