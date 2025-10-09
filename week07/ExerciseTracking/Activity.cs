using System;

abstract class Activity
{
    // 🔹 Common Properties
    public DateTime Date { get; set; }       // Date of the activity
    public int LengthMinutes { get; set; }   // Duration of the activity in minutes

    // 🔹 Constructor
    public Activity(DateTime date, int lengthMinutes)
    {
        Date = date;
        LengthMinutes = lengthMinutes;
    }

    // 🔹 Abstract methods to be implemented by derived classes
    public abstract double GetDistanceKm();       // Distance covered (km)
    public abstract double GetSpeedKmPerHour();   // Average speed (km/h)

    // 🔹 Virtual method for summary (can be overridden for specific formatting)
    public virtual string GetSummary()
    {
        return $"{Date.ToShortDateString()} Activity ({LengthMinutes} min): " +
               $"Distance {GetDistanceKm():F2} km, Speed {GetSpeedKmPerHour():F2} km/h";
    }
}
