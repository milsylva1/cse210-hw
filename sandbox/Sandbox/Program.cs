using System;
using System.Collections.Generic;
using System.IO;
class Program
{
    static void Main(string[] args)
    {
        Person p1 = new Person();
        p1._firstName = "";
        p1._lastName = "---";
        p1._age = 25;

        Person p2 = new Person();
        p2._firstName = "---";
        p2._lastName = "";
        p2._age = 30;
        
       
        List<Person> people = new List<Person>();
        people.Add(p1);
        people.Add(p2);

        foreach(Person p in people)
        {
            Console.WriteLine(p._firstName);
        }

        Console.WriteLine("What is one Incredible thing you did today? ");
        string today = Console.ReadLine();
        Console.WriteLine($"Your day was--awesome--{today}");

        DateTime currentDateTime = DateTime.Now;
        string formattedDateTime = currentDateTime.
        ToString("dddd, dd MMMM yyyy HH:mm:ss");
        Console.WriteLine($"{currentDateTime}");
        
        
        SaveToFile(people);

    }
    public static void SaveToFile(List<Person> people)
    {
        Console.WriteLine("Saving to file...");

        string filename = "people.txt";

        using(StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach(Person p in people)
        {
            outputFile.WriteLine(p._firstName);
        }
        }
    }
    public static List<Person> ReadFromFile()
    {
        List<Person>people = new List<Person>();
        string filename = "people.txt";

        return people;
    }
}