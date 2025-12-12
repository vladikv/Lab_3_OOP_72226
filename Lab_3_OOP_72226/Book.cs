using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3_OOP_72226
{
    public class Book
    {
        protected string title;
        protected Person author;
        protected int year;

        public Book(string title, Person author, int year)
        {
            this.title = title;
            this.author = author;
            this.year = year;
        }

        public virtual void View()
        {
            Console.WriteLine($"{title}, {author.GetFirstName} {author.GetLastName}, {year}");
        }

        public string Title => title;
    }
}
