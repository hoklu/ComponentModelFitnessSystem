using FitnessSystemComponentExample.Contracts;

public class CHeartRateSensorRandom : IHeartRate
{
    private readonly Random rand = new();

    public CHeartRateSensorRandom(DegreeOfReality degreeOfReality)
    {
        
    }

    public int GetCurrentHeartRate()
    {
        return rand.Next(30, 200);
    }
}