using System.Globalization;

namespace Lab2
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
            Console.WriteLine($"Saldo konta: {kwota.ToString("C", new CultureInfo("pl-PL"))}");
        }

        public void wlasciciel()
        {
            Console.WriteLine($"Wlasciciel konta to:{imie} {nazwisko}");
        }

        public decimal wplata(decimal wplata)
        {
            if (wplata > 0) kwota = kwota + wplata;
            else throw new ArgumentException("Nieprawidłowa kwota wpłaty!");
            Console.WriteLine($"Wpłacono {wplata.ToString("C", new CultureInfo("pl-PL"))} na twoje konto.");
            return kwota;
        }
        public decimal wyplata(decimal wyplata)
        {
            if (wyplata < kwota) kwota = kwota - wyplata;
            else throw new ArgumentException("Brak wystarczających środków na koncie!");
            Console.WriteLine($"Wypłacono {wyplata.ToString("C", new CultureInfo("pl-PL"))} z twojego konta.");
            return kwota;
        }
        public void view()
        {
            Console.WriteLine($"Imie: {imie} \tNazwisko: {nazwisko} \tSaldo: {kwota.ToString("C", new CultureInfo("pl-PL"))}");
        }
    }
}