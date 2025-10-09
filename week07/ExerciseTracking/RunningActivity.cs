using System;

class RunningActivity
{
    // 🔹 Properties
    public DateTime Date { get; set; }         // Date of the run
    public int LengthMinutes { get; set; }     // Duration in minutes
    public double DistanceKm { get; set; }     // Distance covered in kilometers

    // 🔹 Constructor
    public RunningActivity(DateTime date, int lengthMinutes, double distanceKm)
    {
        Date = date;
        LengthMinutes = lengthMinutes;
        DistanceKm = distanceKm;
    }

    // 🔹 Method to calculate average speed
    public double GetSpeedKmPerHour()
    {
        return (DistanceKm / LengthMinutes) * 60.0;
    }

    // 🔹 Method to calculate pace (minutes per km)
    public double GetPaceMinutesPerKm()
    {
        return LengthMinutes / DistanceKm;
    }

    // 🔹 Method to get summary information
    public string GetSummary()
    {
        return $"{Date.ToShortDateString()} Running Activity ({LengthMinutes} min): " +
               $"Distance {DistanceKm:F2} km, Speed {GetSpeedKmPerHour():F2} km/h, " +
               $"Pace {GetPaceMinutesPerKm():F2} min/km";
    }
}
