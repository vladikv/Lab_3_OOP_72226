using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3_OOP_72226
{
    public class Reviewer : Reader
    {
        private Random rnd = new Random();

        public Reviewer(string fn, string ln, int age) : base(fn, ln, age)
        {
        }

        public override void View()
        {
            base.View();
            Console.WriteLine("Oceny:");
            foreach (var b in Books)
            {
                Console.WriteLine($" - {b.Title}: {rnd.Next(1, 11)}/10");
            }
        }
    }

}
