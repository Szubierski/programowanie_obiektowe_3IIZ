using System.Net.Http.Headers;
using Microsoft.VisualBasic.CompilerServices;

namespace Lab3;

public class Employee
{
    public string FirstName { get; }
    public string LastName { get; }
    public IContract Contract { get; private set; }

    public Employee(string FirstName, string LastName) : this(FirstName, LastName, new Internship())
    { }

    public Employee(string FirstName, string LastName, IContract Contract)
    {
        FirstName = string.IsNullOrWhiteSpace(FirstName) ? throw new ArgumentNullException(nameof(FirstName)) : FirstName;
        LastName = string.IsNullOrWhiteSpace(LastName) ? throw new ArgumentNullException(nameof(LastName)) : LastName;
        Contract = Contract ?? throw new ArgumentNullException(nameof(Contract));
    }

    public void ZmienKontrakt(IContract nowyKontrakt)
    {
        Contract = nowyKontrakt ??  throw new ArgumentNullException(nameof(nowyKontrakt));
    }

    public decimal Pensja()
    {
        return Contract.Salary();
    }

    public override string ToString()
    {
        return $"Pracownik {FirstName} {LastName}" + 
               $"(Pensja: {Pensja().ToString("C", new CultureInfo("pl-PL"))})" +
               $"Kontrakt: {Contract}";
    }
}

