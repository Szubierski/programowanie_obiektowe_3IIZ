namespace Lab3;

public class Position : IContract
{
    public Position()
    {
        MontlyRate = 500m;
        Overtime = 0;
    }
    public Position(decimal montlyRate, int overtime)
    {
        MontlyRate = montlyRate;
        Overtime = overtime;
    }

    public decimal MontlyRate {get; set;}
    public int Overtime {get; set;}

    public decimal Salary()
    {
        return MontlyRate + Overtime * (MontlyRate / 60m);
    }

    public override string ToString()
    {
        return $"Etat ({StawkaMiesieczna.ToString("C", new CultureInfo("pl-PL"))})";
    }
}