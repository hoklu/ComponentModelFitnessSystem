using FitnessSystemComponentExample.Contracts;

public class CHeartRateSensorStatic : IHeartRate
{
    public int GetCurrentHeartRate()
    {
        return 120;
    }
}