public class Writing Assignment: Assignment
{ 
public string Title { get; set; }
public WritingAssignment(string studentName, string topic, string title);
     :base ( studentName, topic);
     {
     Title =title;
     }
     public string GetWritingInformation()
    {
        return $"{Title} by {StudentName}";
    }
}
