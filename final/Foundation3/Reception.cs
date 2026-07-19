using System;

public class Reception : Event
{
    private string _rsvpEmail;

    public Reception(string title, string type, string date, string time, Address address, string rsvpEmail) : base(type, title, date, time, address)
    {
        _rsvpEmail = rsvpEmail;
    }
    public override string GetFullDetails()
    {
        return $"{GetStandardDetails()}\nPlease RSVP to: {_rsvpEmail}";
    }
}