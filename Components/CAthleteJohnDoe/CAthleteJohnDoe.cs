
using FitnessSystemComponentExample.Contracts;

public class CAthleteJohnDoe : IAthleteProfile
{

    public DateOnly GetBirthday()
    {
        return new DateOnly(1983, 8, 28);
    }

    public string GetFirstName()
    {
        return "John";
    }

    public string GetLastName()
    {
        return "Doe";
    }

    public double GetWeight()
    {
        return 86.5;
    }
}