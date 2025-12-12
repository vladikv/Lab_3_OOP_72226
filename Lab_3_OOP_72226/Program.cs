using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3_OOP_72226
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person a = new Person("Jan", "Kowalski", 40);
            Reader r1 = new Reader("Anna", "Nowak", 25);
            Reviewer rev1 = new Reviewer("Tomasz", "Wiśniewski", 30);

            Book b1 = new Book("Ogniem i Mieczem", a, 1884);
            Book b2 = new AdventureBook("Władca Pierścieni", a, 1954, "Śródziemie");
            Book b3 = new DocumentaryBook("Kosmos", a, 1980, "Astronomia");

            r1.AddBook(b1);
            r1.AddBook(b2);

            rev1.AddBook(b2);
            rev1.AddBook(b3);

            List<Person> list = new List<Person>()
        {
            a, r1, rev1
        };

            foreach (var p in list)
            {
                p.View();
                Console.WriteLine();
            }
        }
    }
}
