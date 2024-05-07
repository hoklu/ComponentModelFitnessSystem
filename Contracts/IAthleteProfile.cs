namespace FitnessSystemComponentExample.Contracts
{
    public interface IAthleteProfile
    {
        public string GetFirstName();

        public string GetLastName();

        public DateOnly GetBirthday();

        public double GetWeight();
    }
}