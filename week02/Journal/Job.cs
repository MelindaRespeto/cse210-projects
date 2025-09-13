using System;

public class Job
{
    private string _date;
    private string _prompt;
    private string _entryText;

    public Job(string date, string prompt, string entryText)
    {
        _date = date;
        _prompt = prompt;
        _entryText = entryText;
    }

    public string GetEntryDetails()
    {
        return $"{_date} - {_prompt}\n{_entryText}";
    }

    public string ToFileFormat()
    {
        return $"{_date}~{_prompt}~{_entryText}";
    }

    public static Job FromFileFormat(string line)
    {
        string[] parts = line.Split('~');
        if (parts.Length == 3)
        {
            return new Job(parts[0], parts[1], parts[2]);
        }
        return null;
    }
}



