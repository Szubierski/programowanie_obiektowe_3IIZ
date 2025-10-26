using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Text;

namespace lab2
{
    public class BankAccount
    {
        private string imie;
        private string nazwisko;
        public decimal kwota;

        public BankAccount(string imie, string nazwisko, decimal kwota)
        {
            this.imie = imie;
            this.nazwisko = nazwisko;
            this.kwota = kwota;
        }

        public void saldo()
        {
            Console.WriteLine("Saldo konta: " + kwota.ToString("C", new CultureInfo("pl-PL")));
        }

        public void wlasciciel()
        {
            Console.WriteLine("Wlasciciel konta to: "+imie+" "+nazwisko);
        }

        public decimal wplata(decimal wplata)
        {
            if (wplata > 0)
            {
                kwota = kwota + wplata;
            }
            else
            {
                Console.WriteLine("Nieprawidłowa kwota wpłay!");
            }
            return kwota;
        }
        public decimal wyplata(decimal wyplata)
        {
            if (wyplata < kwota) kwota = kwota - wyplata;
            else throw new Exception("Brak srodkow na koncie!");
            return kwota;
        }
        public void view()
        {
            Console.WriteLine("Imie: "+imie+"" +"\tNazwisko: "+nazwisko+"\tSaldo: "+ kwota.ToString("C", new CultureInfo("pl-PL")));
        }
    }
}
