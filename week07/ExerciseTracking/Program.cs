using System;
using System.Collections.Generic;

//
// 🔹 Base Class: Activity
//
abstract class Activity
{
    public DateTime Date { get; set; }       // Date of the activity
    public int LengthMinutes { get; set; }   // Duration in minutes

    public Activity(DateTime date, int lengthMinutes)
    {
        Date = date;
        LengthMinutes = lengthMinutes;
    }

    public abstract double GetDistanceKm();       // Must be defined by subclasses
    public abstract double GetSpeedKmPerHour();   // Must be defined by subclasses

    public virtual string GetSummary()
    {
        return $"{Date.ToShortDateString()} Activity ({LengthMinutes} min): " +
               $"Distance {GetDistanceKm():F2} km, Speed {GetSpeedKmPerHour():F2} km/h";
    }
}

//
// 🏃 RunningActivity
//
class RunningActivity : Activity
{
    public double DistanceKm { get; set; }

    public RunningActivity(DateTime date, int lengthMinutes, double distanceKm)
        : base(date, lengthMinutes)
    {
        DistanceKm = distanceKm;
    }

    public override double GetDistanceKm()
    {
        return DistanceKm;
    }

    public override double GetSpeedKmPerHour()
    {
        return (DistanceKm / LengthMinutes) * 60.0;
    }

    public double GetPaceMinutesPerKm()
    {
        return LengthMinutes / DistanceKm;
    }

    public override string GetSummary()
    {
        return $"{Date.ToShortDateString()} Running Activity ({LengthMinutes} min): " +
               $"Distance {GetDistanceKm():F2} km, Speed {GetSpeedKmPerHour():F2} km/h, " +
               $"Pace {GetPaceMinutesPerKm():F2} min/km";
    }
}

//
// 🚴 StationaryBicycleActivity
//
class StationaryBicycleActivity : Activity
{
    public double SpeedKmPerHour { get; set; }

    public StationaryBicycleActivity(DateTime date, int lengthMinutes, double speedKmPerHour)
        : base(date, lengthMinutes)
    {
        SpeedKmPerHour = speedKmPerHour;
    }

    public override double GetDistanceKm()
    {
        return (SpeedKmPerHour * LengthMinutes) / 60.0;
    }

    public override double GetSpeedKmPerHour()
    {
        return SpeedKmPerHour;
    }

    public override string GetSummary()
    {
        return $"{Date.ToShortDateString()} Stationary Bicycle Activity ({LengthMinutes} min): " +
               $"Distance {GetDistanceKm():F2} km, Speed {SpeedKmPerHour:F2} km/h";
    }
}

//
// 🏊 SwimmingActivity
//
class SwimmingActivity : Activity
{
    public int Laps { get; set; }
    private const double LapLengthMeters = 50;

    public SwimmingActivity(DateTime date, int lengthMinutes, int laps)
        : base(date, lengthMinutes)
    {
        Laps = laps;
    }

    public override double GetDistanceKm()
    {
        return (Laps * LapLengthMeters) / 1000.0;
    }

    public override double GetSpeedKmPerHour()
    {
        return (GetDistanceKm() / LengthMinutes) * 60.0;
    }

    public override string GetSummary()
    {
        return $"{Date.ToShortDateString()} Swimming Activity ({LengthMinutes} min): " +
               $"Laps {Laps}, Distance {GetDistanceKm():F2} km, Speed {GetSpeedKmPerHour():F2} km/h";
    }
}

//
// 🧩 Main Program
//
class Program
{
    static void Main()
    {
        // Create a list of different activities
        List<Activity> activities = new List<Activity>
        {
            new RunningActivity(new DateTime(2025, 10, 9), 30, 6.0),
            new StationaryBicycleActivity(new DateTime(2025, 10, 9), 45, 20.0),
            new SwimmingActivity(new DateTime(2025, 10, 9), 40, 30)
        };

        // Display summaries for all activities using polymorphism
        Console.WriteLine("🏋️‍♂️ ACTIVITY SUMMARIES\n");
        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}
