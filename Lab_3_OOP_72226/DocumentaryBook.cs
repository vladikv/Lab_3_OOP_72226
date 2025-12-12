using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3_OOP_72226
{
    public class DocumentaryBook : Book
    {
        private string topic;

        public DocumentaryBook(string title, Person author, int year, string topic)
            : base(title, author, year)
        {
            this.topic = topic;
        }

        public override void View()
        {
            Console.WriteLine($"{title}, {author.GetFirstName} {author.GetLastName}, {year}, Temat: {topic}");
        }
    }
}
