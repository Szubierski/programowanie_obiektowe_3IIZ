using System.Globalization;

namespace Lab3;

public class Internship : IContract
{
    public Internship()
    {
        StawkaMiesieczna = 1000m;
    }

    public Internship(decimal stawkaMiesieczna)
    {
        StawkaMiesieczna = stawkaMiesieczna;
    }
    public decimal StawkaMiesieczna { get; set; }

    public decimal Salary()
    {
        return StawkaMiesieczna;
    }

    public override string? ToString()
    {
        return $"Staz ({StawkaMiesieczna.ToString("C", new CultureInfo("pl-PL"))})";
    }
}