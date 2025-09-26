public class Assignment
{
    public string StudentName { get; set; }
    public string Topic { get; set; }

    public Assignment(string studentName, string topic)
    {
        StudentName = studentName;
        Topic = topic;
    }

    public string GetSummary()
    {
        return $"{StudentName} - Topic: {Topic}";
    }
}

