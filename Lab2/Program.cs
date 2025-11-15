using Lab2;

public class Program
{
    public static void Main(string[] args)
    {
        // Zad. 1
        Console.WriteLine("Zad. 1\n");
        
        try
        {
            // Prawidłowe dane
            Osoba osoba1 = new Osoba("Jan", "Kowalski", 25);
            osoba1.WyświetlInformacje();
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine($"Błąd: {ex.Message}");
        }
        try
        {
            // Nieprawidłowy wiek
            Osoba osoba2 = new Osoba("Adam", "Nowak", -5); // To powinno wywołać wyjątek
            osoba2.WyświetlInformacje();
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine($"Błąd: {ex.Message}");
        }
        try
        {
            // Nieprawidłowe imię
            Osoba osoba3 = new Osoba("A", "Nowak", 30); // To powinno wywołać wyjątek
            osoba3.WyświetlInformacje();
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine($"Błąd: {ex.Message}");
        }

        // Zad. 2 
        Console.WriteLine("\nZad. 2");
        try
        {
            // Nieprawidłowa wypłata
            BankAccount bankAccount = new BankAccount("Nikodem", "Szubierski", 1m);
            bankAccount.view();
            bankAccount.wyplata(2); // To powinno wywołać wyjątek

        }
        catch (ArgumentException ex)
        {
            Console.WriteLine($"Błąd: {ex.Message}");
        }
        try
        {
            // Nieprawidłowa wpłata
            BankAccount bankAccount = new BankAccount("Nikodem", "Szubierski", 1m);
            bankAccount.view();
            bankAccount.wplata(-5); // To powinno wywołać wyjątek

        }
        catch (ArgumentException ex)
        {
            Console.WriteLine($"Błąd: {ex.Message}");
        }
        try
        {
            // Prawidłowe dane
            BankAccount bankAccount = new BankAccount("Nikodem", "Szubierski", 1m);
            bankAccount.view();
            bankAccount.wplata(10);
            bankAccount.wyplata(5);

        }
        catch (ArgumentException ex)
        {
            Console.WriteLine($"Błąd: {ex.Message}");
        }

        // Zad. 3
        Console.WriteLine("\nZad. 3");
        try
        {
            // Prawidłowe dane
            Student student = new Student("Anna", "Nowak");
            student.wypiszDane();
            student.dodajOcene(5);
            student.dodajOcene(4);
            student.dodajOcene(2);
            Console.WriteLine($"Średnia ocen studenta {student.srednia()}");

        }
        catch (ArgumentException ex)
        {
            Console.WriteLine($"Błąd: {ex.Message}");
        }
        try
        {
            // Nieprawidłowe dane
            Console.WriteLine("");
            Student student = new Student("Kamil", "Zdun");
            student.wypiszDane();
            student.dodajOcene(-1);
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine($"Błąd: {ex.Message}");
        }

        // Zad. 4
        Console.WriteLine("\nZad. 4");
        Licz licz = new Licz(10);
        licz.Wyswietl();
        licz.Dodaj(5);
        licz.Wyswietl();
        licz.Odejmij(3);
        licz.Wyswietl();
        /* 
            licz.value = 100; <- nie można tak zrobić gdy value jest prywatne
            licz.Wyswietl();

            Wynik działania programu dla publicznego value:

            Aktualna wartość: 10
            Aktualna wartość: 15
            Aktualna wartość: 12
            Aktualna wartość: 100
        */

        // Zad. 5
        Console.WriteLine("\nZad. 5");
        try
        {
            // Prawidłowe dane
            Sumator sumator = new Sumator([1, 2, 3, 4, 5]);
            sumator.WyswietlLiczby();
            Console.WriteLine($"Suma: {sumator.Suma()}");
            Console.WriteLine($"Suma podzielona przez 2: {sumator.SumaPodziel2()}");
            sumator.WypiszWPrzedziale(1, 3);
            Console.WriteLine("");
            sumator.WypiszWPrzedziale(-1, 10);
            Console.WriteLine($"Liczba elementów w tablicy: {sumator.ileElementow()}");
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine($"Błąd: {ex.Message}");
        }
        try
        {
            // Prawidłowe dane
            Console.WriteLine("");
            Sumator sumator = new Sumator([1, 2, 3, 4, 5, 8, 9, 2, 10]);
            sumator.WyswietlLiczby();
            sumator.WypiszWPrzedziale(20, 10);
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine($"Błąd: {ex.Message}");
        }
    }
}