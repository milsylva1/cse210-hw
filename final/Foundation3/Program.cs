using System;

class Program
{
    static void Main(string[] args)
    {
        Address address = new Address("1409 E. Diamond St", "Phoenix", "AZ", "85006");
        Lecture lecture = new Lecture("Mils Wise Program", "Learn Coding C#", "2024-02-15", "10:00 AM", address, "Ermilus", 32);
        Reception reception = new ("Networking Mixer", "Network with professionals", "2024-02-20", "6:00 PM", address, "msylvainusa@gmail.com");
        OutdoorGathering outdoorGathering = new OutdoorGathering("Cronado Park II", "Enjoy a day outdoors", "2024-02-25", "12:00 PM", address);

        Event[] events = { lecture, reception, outdoorGathering };

        foreach (Event e in events)
        {
            Console.WriteLine("Standard Details:");
            Console.WriteLine(e.GetStandardDetails());

            Console.WriteLine("\nShort Description:");
            Console.WriteLine(e.GetShortDescription());

            Console.WriteLine();
        }
    }
}
