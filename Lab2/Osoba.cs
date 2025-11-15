using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    public class Osoba
    {
        // pola prywatne
        private string imie;
        private string nazwisko;
        private int wiek;

        public string Imie
        {
            get { return imie; }
            set 
            { 
               if(string.IsNullOrWhiteSpace(value) || value.Length < 2)
                {
                    throw new ArgumentException("Imię musi składać sie z conajmniej 2 znaków.");
                }
                imie = value; 
            }
        }
        public string Nazwisko
        {
            get { return nazwisko; }
            set 
            { 
               if(string.IsNullOrWhiteSpace(value) || value.Length < 2)
                {
                    throw new ArgumentException("Imię musi składać sie z conajmniej 2 znaków.");
                }
                nazwisko = value; 
            }
        }

        public int Wiek
        {
            get { return wiek; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Wiek musi być liczbą dodatanią");
                }
                wiek = value;
            }
        }

        public Osoba (string imie, string nazwisko, int wiek)
        {
            Imie = imie;
            Nazwisko = nazwisko;
            Wiek = wiek;
        }

        public void WyświetlInformacje()
        {
            Console.WriteLine($"Imię: {Imie}, \tNazwisko: {Nazwisko}, \tWiek: {Wiek}");
        }
    }
}
