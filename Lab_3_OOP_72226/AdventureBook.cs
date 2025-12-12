using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3_OOP_72226
{
    public class AdventureBook : Book
    {
        private string world;

        public AdventureBook(string title, Person author, int year, string world)
            : base(title, author, year)
        {
            this.world = world;
        }

        public override void View()
        {
            Console.WriteLine($"{title}, {author.GetFirstName} {author.GetLastName}, {year}, Świat: {world}");
        }
    }
}
