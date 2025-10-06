using System;

public class ChecklistGoal : Goal
{
    private int _targetCount;
    private int _currentCount;
    private int _bonus;

    public ChecklistGoal(string name, string description, int points, int targetCount, int bonus, int currentCount = 0)
        : base(name, description, points)
    {
        _targetCount = targetCount;
        _currentCount = currentCount;
        _bonus = bonus;
        _isComplete = _currentCount >= _targetCount;
    }

    public override int RecordEvent()
    {
        if (_isComplete)
        {
            Console.WriteLine($"Goal '{_name}' already completed!");
            return 0;
        }

        _currentCount++;
        int earned = _points;

        if (_currentCount >= _targetCount)
        {
            _isComplete = true;
            earned += _bonus;
            Console.WriteLine($"Goal '{_name}' completed! You earned {_points} + {_bonus} bonus points!");
        }
        else
        {
            Console.WriteLine($"Progress: {_currentCount}/{_targetCount}. You earned {_points} points.");
        }

        return earned;
    }

    public override bool IsComplete() => _isComplete;

    public override void DisplayGoal()
    {
        string status = _isComplete ? "[X]" : "[ ]";
        Console.WriteLine($"{status} {_name} ({_description}) -- Completed {_currentCount}/{_targetCount} times");
    }

    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal|{_name}|{_description}|{_points}|{_bonus}|{_targetCount}|{_currentCount}";
    }
}
