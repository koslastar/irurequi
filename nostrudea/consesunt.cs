using System;
using System.Collections.Generic;

class Event
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Date { get; set; }

    public override string ToString()
    {
        return $"Event {{ Id = {Id}, Name = '{Name}', Date = '{Date}' }}";
    }
}

class Program
{
    static void Main()
    {
        var events = new List<Event>
        {
            new Event { Id = 1, Name = "Event 1", Date = "2024-06-22" },
            new Event { Id = 2, Name = "Event 2", Date = "2024-07-15" },
            new Event { Id = 3, Name = "Event 3", Date = "2024-08-30" }
        };

        int eventId = 2;
        Event event = GetEventById(events, eventId);
        if (event != null)
        {
            Console.WriteLine($"Event found: {event}");
        }
        else
        {
            Console.WriteLine("Event not found");
        }
    }

    static Event GetEventById(List<Event> events, int eventId)
    {
        foreach (var e in events)
        {
            if (e.Id == eventId)
            {
                return e;
            }
        }
        return null;
    }
}
