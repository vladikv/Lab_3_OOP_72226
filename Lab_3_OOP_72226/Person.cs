using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3_OOP_72226
{
    public class Person
    {
        private string FirstName;
        private string LastName;
        private int Age;

        public Person(string firstName, string lastName, int age)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
        }

        public virtual void View()
        {
            Console.WriteLine($"{FirstName} {LastName}, wiek: {Age}");
        }

        
        public string GetFirstName => FirstName;
        public string GetLastName => LastName;
    }

}
