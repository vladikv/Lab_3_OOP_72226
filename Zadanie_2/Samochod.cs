using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_2
{
    public class Samochod
    {
        public string Marka;
        public string Model;
        public string Nadwozie;
        public string Kolor;
        public int Rok;
        private double przebieg;

        public double Przebieg
        {
            get => przebieg;
            set => przebieg = value < 0 ? 0 : value;
        }

        public Samochod()
        {
            Console.Write("Marka: ");
            Marka = Console.ReadLine();
            Console.Write("Model: ");
            Model = Console.ReadLine();
            Console.Write("Nadwozie: ");
            Nadwozie = Console.ReadLine();
            Console.Write("Kolor: ");
            Kolor = Console.ReadLine();
            Console.Write("Rok produkcji: ");
            Rok = int.Parse(Console.ReadLine());
            Console.Write("Przebieg: ");
            Przebieg = double.Parse(Console.ReadLine());
        }

        public Samochod(string marka, string model, string nadwozie,
            string kolor, int rok, double przebieg)
        {
            Marka = marka;
            Model = model;
            Nadwozie = nadwozie;
            Kolor = kolor;
            Rok = rok;
            Przebieg = przebieg;
        }

        public virtual void View()
        {
            Console.WriteLine($"{Marka} {Model}, {Nadwozie}, {Kolor}, {Rok}, przebieg: {Przebieg}");
        }
    }

}
