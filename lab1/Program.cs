// zad 1. Funkcja kwadratowa
Console.WriteLine("Zad.2");
void quadraticFunction(double a, double b, double c)
{
    // deklaracja zmiennych
    double x, x1, x2, delta;

    // obliczanie delty
    delta = (b * b) - (4 * a * c);

    // sprawdzanie wartości delty
    if (delta < 0)
        Console.WriteLine("Brak miejsc zerowych\n");
    else if (delta == 0)
    {
        // obliczanie miejsca zerowego
        x = -b / (2 * a);
        Console.WriteLine("x = " + x + "\n");
    }
    else 
    {
        // obliczanie miejsc zerowych

        double deltaSqrt = Math.Sqrt(delta);

        x1 = -b + deltaSqrt / (2 * a);
        x2 = -b - deltaSqrt / (2 * a);

        Console.WriteLine("x1 = " + x1 + "\tx2 = " + x2 + "\n");
    }
}

quadraticFunction(1.0, -3.0, 2.0); // Przykładowe wywołanie funkcji z a=1, b=-3, c=2
quadraticFunction(1, 1, 1); // Przykładowe wywołanie funkcji z a=1, b=-1, c=1

// zad 2. 10 liczb
Console.WriteLine("Zad. 2");
int[] getTenNumbers()
{
    // Inicjalizacja zmiennych
    string temp;
    int[] numbers = new int[10];

    for (int i = 0; i < 10; i++)
    {
        // Pobieranie liczby od użytkownika
        Console.Write("Podaj liczbę całkowitą " + (i + 1) + ": ");
        temp = Console.ReadLine();
        // Sprawdzanie czy pole nie jest puste
        while (temp == "")
        {
            // Jeśli pole jest puste, prośba o ponowne podanie liczby
            Console.Write("Pole nie może być puste. Podaj liczbę "+ (i + 1) + ": ");
            temp = Console.ReadLine();
        }
        // Konwersja i przechowywanie liczby w tablicy
        numbers[i] = int.Parse(temp);
    }
    // Zwracanie tablicy z 10 liczbami
    return numbers;
}

// Pobieranie 10 liczb od użytkownika
int[] numbers = getTenNumbers();

int sum(int[] numbers)
{
    // Zwraca sumę wszystkich liczb w tablicy
    return numbers.Sum();
}

int multiply(int[] numbers)
{
    // Oblicza iloczyn wszystkich liczb w tablicy
    int result = 1;
    foreach (int number in numbers)
    {
        result *= number;
    }
    // Zwraca iloczyn
    return result;
}

double average(int[] numbers)
{
    // Zwraca średnią wartość w tablicy liczb
    return (double)sum(numbers) / numbers.Length;
}

int min(int[] numbers)
{
    // Zwraca minimalną wartość w tablicy liczb
    return numbers.Min();
}

int max(int[] numbers)
{
    // Zwraca maksymalną wartość w tablicy liczb
    return numbers.Max();
}

// Wyświetlanie wyników

Console.WriteLine("\nSuma tych liczb wynosi: " + sum(numbers) + "\n");
Console.WriteLine("Iloczyn tych liczb wynosi: " + multiply(numbers) + "\n");
Console.WriteLine("Średnia tych liczb wynosi: " + average(numbers) + "\n");
Console.WriteLine("Wartość minimalna spośród tych liczb wynosi: " + min(numbers) + "\n");
Console.WriteLine("Wartość maksymalna spośród tych liczb wynosi: " + max(numbers) + "\n");

// zad. 3 Użycie continue

Console.WriteLine("Zad. 3");

void useContinue()
{
    for (int i = 20; i >= 0; i--)
    {
        if (i == 2 || i == 6 || i == 9 || i == 15 || i == 19)
        {
            continue; // pomija liczby 2, 6, 9, 15, 19
        }
        Console.Write(i + ""); // wypisuje pozostałe liczby od 20 do 0
    }
}

useContinue();

// zad. 4 Nieskończona pętla z z break

Console.WriteLine("\n\nZad. 4");

void infiniteLoopWithBreak()
{
    // Nieskończona pętla
    while (true)
    {
        // Pobieranie liczby od użytkownika
        Console.Write("Podaj liczbę całkowitą (lub ujemną, aby zakończyć): ");

        string x = Console.ReadLine();
        int xInt = x == "" ? 1 : int.Parse(x);

        if (xInt < 0)
        {
            // Przerwanie pętli, jeśli liczba jest ujemna
            break; 
        }
    }
}

infiniteLoopWithBreak();

// zad. 5 Sortowanie bąbelkowe liczb podanych przez użytkownika

Console.WriteLine("\nZad. 5");

int[] getNNumbers()
{
    // Inicjalizacja zmiennych
    string temp;
    Console.Write("Ile liczb chcesz posortować?: ");
    temp = Console.ReadLine();
    int n = temp == "" ? 0 : int.Parse(temp);
    int[] numbers = new int[n];

    for (int i = 0; i < n; i++)
    {
        // Pobieranie liczby od użytkownika
        Console.Write("Podaj liczbę całkowitą " + (i + 1) + ": ");
        temp = Console.ReadLine();
        // Sprawdzanie czy pole nie jest puste
        while (temp == "")
        {
            // Jeśli pole jest puste, prośba o ponowne podanie liczby
            Console.Write("Pole nie może być puste. Podaj liczbę " + (i + 1) + ": ");
            temp = Console.ReadLine();
        }
        // Konwersja i przechowywanie liczby w tablicy
        numbers[i] = int.Parse(temp);
    }
    // Zwracanie tablicy z n liczbami
    return numbers;
}

int[] bubbleSort(int[] numbers)
{
    int n = numbers.Length;
    // Pętla przechodząca przez wszystkie elementy tablicy
    for (int i = 0; i < n - 1; i++)
    {
        // Pętla wewnętrzna do porównywania sąsiednich elementów
        for (int j = 0; j < n - i - 1; j++)
        {
            // Jeśli element jest większy niż następny, zamień je miejscami
            if (numbers[j] > numbers[j + 1])
            {
                int temp = numbers[j];
                numbers[j] = numbers[j + 1];
                numbers[j + 1] = temp;
            }
        }
    }
    // Zwracanie posortowanej tablicy
    return numbers;
}

// Pobieranie n liczb od użytkownika
int[] numbersToSort = getNNumbers();

// Liczby przed posortowaniem
Console.WriteLine("\nLiczby przed posortowaniem: ");
foreach (int number in numbersToSort)
{
    Console.Write(number + " ");
}

// Sortowanie liczb za pomocą sortowania bąbelkowego
Console.WriteLine("\nPosortowane liczby: ");
foreach (int number in bubbleSort(numbersToSort))
{
    Console.Write(number + " "); // Wyświetlanie posortowanych liczb
}