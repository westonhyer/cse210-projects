using System;

public class WrittingAssignment : Assignment
{
    private string _title = "";

    public WrittingAssignment(string title, string studentName, string topic) : base(studentName, topic)
    {
        _title = title;
    }

    public string GetWrittingInformation()
    {
        return $"Title: {_title}";
    }
}