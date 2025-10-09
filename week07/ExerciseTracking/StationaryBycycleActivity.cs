using System;

class StationaryBicycleActivity
{
    // Properties
    public double DistanceKm { get; set; }
    public double DurationMinutes { get; set; }
    public double CaloriesBurned { get; private set; }

    // Constructor
    public StationaryBicycleActivity(double distanceKm, double durationMinutes)
    {
        DistanceKm = distanceKm;
        DurationMinutes = durationMinutes;
        CaloriesBurned = CalculateCalories();
    }

    // Method to calculate average speed
    public double GetSpeedKmPerHour()
    {
        return (DistanceKm / DurationMinutes) * 60; // km per hour
    }

    // Method to calculate calories burned
    private double CalculateCalories()
    {
        // Simple formula — can be replaced with a more accurate one
        return DurationMinutes * 8; // e.g., 8 calories per minute
    }

    // Method to display summary
    public void DisplaySummary()
    {
        Console.WriteLine("🏁 Stationary Bicycle Activity Summary:");
        Console.WriteLine($"Distance: {DistanceKm} km");
        Console.WriteLine($"Duration: {DurationMinutes} minutes");
        Console.WriteLine($"Average Speed: {GetSpeedKmPerHour():F2} km/h");
        Console.WriteLine($"Calories Burned: {CaloriesBurned} kcal");
    }
}
