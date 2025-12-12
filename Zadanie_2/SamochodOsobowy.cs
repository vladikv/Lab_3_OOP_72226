using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_2
{
    public class SamochodOsobowy : Samochod
    {
        private double waga;
        private double pojemnosc;
        public int IloscOsob;

        public SamochodOsobowy()
            : base()
        {
            Console.Write("Waga (2–4.5 t): ");
            waga = double.Parse(Console.ReadLine());
            if (waga < 2 || waga > 4.5) waga = 2;

            Console.Write("Pojemność (0.8–3.0): ");
            pojemnosc = double.Parse(Console.ReadLine());
            if (pojemnosc < 0.8 || pojemnosc > 3.0) pojemnosc = 0.8;

            Console.Write("Liczba osób: ");
            IloscOsob = int.Parse(Console.ReadLine());
        }

        public override void View()
        {
            base.View();
            Console.WriteLine($"Waga: {waga} t, Pojemność: {pojemnosc} l, Osób: {IloscOsob}");
        }
    }

}
