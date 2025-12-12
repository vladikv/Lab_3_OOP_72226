using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SamochodOsobowy so = new SamochodOsobowy();

            Samochod s1 = new Samochod();
            Samochod s2 = new Samochod("Toyota", "Yaris", "Hatchback", "Czerwony", 2020, 45000);

            so.View();
            s1.View();
            s2.View();
        }
    }
}
