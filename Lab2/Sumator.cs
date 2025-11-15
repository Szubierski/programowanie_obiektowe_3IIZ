using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    internal class Sumator
    {
        private int[] Liczby = [];

        public Sumator(int[] liczby)
        {
            if(liczby.Length == 0) throw new ArgumentException("Tablica nie może być pusta.");
            else Liczby = liczby;
        }

        public int Suma()
        {
            return Liczby.Sum();
        }

        public double SumaPodziel2()
        {
            return Suma() / 2;
        }

        public int ileElementow()
        {
            return Liczby.Length;
        }

        public void WyswietlLiczby()
        {
            Console.WriteLine($"Liczby w tablicy: {string.Join(", ", Liczby)}");
        }

        public void WypiszWPrzedziale(int lowIndex, int highIndex)
        {
            if (lowIndex > highIndex) throw new ArgumentException("Indeks początkowy nie może być większy od końcowego.");
            else
            {
                for (int i = lowIndex; i <= highIndex; i++)
                {
                    if (i < 0 || i >= Liczby.Length) continue;
                    else Console.WriteLine($"Element na indeksie {i}: {Liczby[i]} ");
                }
            }
        }
    }
}
