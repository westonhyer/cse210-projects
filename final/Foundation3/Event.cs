using System;

public class Event
{
    private string _type;
    private string _title;
    private string _description;
    private string _date;
    private string _time;
    private Address _address;

    public Event(string type, string title, string date, string time, Address address)
    {
        _type = type;
        _title = title;
        _date = date;
        _time = time;
        _address = address;
        _description = GetDescription();
    }

    public string GetStandardDetails()
    {
        return $"{_description} @ {_time}\n\n{_address.GetAddress()}\n";
    }

    public virtual string GetFullDetails()
    {
        return GetStandardDetails();
    }

    public string GetDescription()
    {
        return $"Title: {_title}\nEvent Type: {_type}\nDate: {_date}";
    }
}