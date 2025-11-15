using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    internal class Student
    {
        private string imie;
        private string nazwisko;
        public int[] oceny = [];
    
        public Student(string imie, string nazwisko)
        {
            this.imie = imie;
            this.nazwisko = nazwisko;
        }
        public void dodajOcene(int ocena)
        {
            if(ocena < 2 || ocena > 5)
            {
                throw new ArgumentException("Ocena musi być w przedziale 2-5");
            }
            else
            {
                Array.Resize(ref oceny, oceny.Length + 1);
                oceny[oceny.Length - 1] = ocena;
                Console.WriteLine($"Dodano ocenę {ocena}");
            }
        }

        public double srednia()
        {
            if (oceny.Length == 0) return 0;
            return oceny.Average();
        }

        public void wypiszDane()
        {
            Console.WriteLine($"Student: {imie} {nazwisko}");
            Console.WriteLine("Oceny: " + string.Join(", ", oceny));
            Console.WriteLine($"Średnia ocen: {srednia()}");
        }
    }
}
