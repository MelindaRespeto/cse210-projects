using System;

class SwimmingActivity
{
    // 🔹 Properties
    public DateTime Date { get; set; }        // Date of the swimming activity
    public int LengthMinutes { get; set; }    // Duration in minutes
    public int Laps { get; set; }             // Number of laps completed

    // 🔹 Constant for pool length (in meters)
    private const double LapLengthMeters = 50;

    // 🔹 Constructor
    public SwimmingActivity(DateTime date, int lengthMinutes, int laps)
    {
        Date = date;
        LengthMinutes = lengthMinutes;
        Laps = laps;
    }

    // 🔹 Method to calculate total distance in kilometers
    public double GetDistanceKm()
    {
        return (Laps * LapLengthMeters) / 1000.0;
    }

    // 🔹 Method to calculate average speed in km/h
    public double GetSpeedKmPerHour()
    {
        return (GetDistanceKm() / LengthMinutes) * 60.0;
    }

    // 🔹 Method to get summary information
    public string GetSummary()
    {
        return $"{Date.ToShortDateString()} Swimming Activity ({LengthMinutes} min): " +
       
