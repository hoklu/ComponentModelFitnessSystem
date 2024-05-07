using FitnessSystemComponentExample.Contracts;

public class FitnessSystemConfigurator {
    public void ConfigureAndStartSystem() {
        IHeartRate heartRateSensorStatic = new CHeartRateSensorStatic();
        IHeartRate heartRateSensorRandom = new CHeartRateSensorRandom(DegreeOfReality.LOW);
        IAthleteProfile athleteProfileJohnDoe = new CAthleteJohnDoe();

        var fitnessConsole = new CFitnessConsole(heartRateSensorRandom);
        fitnessConsole.AthleteProfile = athleteProfileJohnDoe;
        
        fitnessConsole.StartConsole();
    }
}