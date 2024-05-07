using FitnessSystemComponentExample.Contracts;

public class CFitnessConsole {

    private IHeartRate HeartRateSensor { get; set; }

    public IAthleteProfile? AthleteProfile {private get; set;}

    public CFitnessConsole(IHeartRate heartRateSensor)
    {
        this.HeartRateSensor = heartRateSensor;   
    }

    public void StartConsole() {
        while(true) {
            this.UpdateAndShowValues();
            Thread.Sleep(1000);
        }
    }

    private void UpdateAndShowValues() {
        string statusMessage;

        if (AthleteProfile == null)
        {
            statusMessage = $"HR: {HeartRateSensor.GetCurrentHeartRate()}";
        } else
        {
            statusMessage = $"{AthleteProfile.GetFirstName()} {AthleteProfile.GetLastName()}: HR: {HeartRateSensor.GetCurrentHeartRate()}";
        }

        Console.WriteLine(statusMessage);
    }
}