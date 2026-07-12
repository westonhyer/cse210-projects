using System;

public class Event
{
    private string _type;
    private string _title;
    private string _description;
    private string _date;
    private string _time;
    private Address _address;

    public Event(string type, string title, string description, string date, string time, Address address)
    {
        _type = type;
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
    }

    public string GetStandardDetails()
    {
        return $"Title: {_title}\n{_description}\n{_date} @ {_time}\n{_address}";
    }

    public virtual string GetFullDetails()
    {
        return GetStandardDetails();
    }

    public string GetDescription()
    {
        return $"Event type: {_type}\nTitle: {_title}\n Date: {_date}";
    }
}