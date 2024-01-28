using System;
using System.Collections.Generic;
using System.IO;
class Program
{
    static void Main(string[] args)
    {
        Person p1 = new Person();
        p1._firstprompt ="Who was the most interesting person I interacted with today?";
        p1._2ndprompt = "What was the best part of my day?";
        p1._3rdprompt = "How did I see the hand of the Lord in my life today?";
        p1._4thprompt = "What was the strongest emotion I felt today?";
        p1._5thprompt = "If I had one thing I could do over today, what would it be?";
        p1._line = 25;

        Person p2 = new Person();
       p2._firstprompt = "Who was the most interesting person I interacted with today?";
        p2._2ndprompt = "What was the best part of my day?";
        p2._3rdprompt = "How did I see the hand of the Lord in my life today?";
        p2._4thprompt = "What was the strongest emotion I felt today?";
        p2._5thprompt = "If I had one thing I could do over today, what would it be?";
        p2._line = 30;
        
       
        List<Person> people = new List<Person>();
        people.Add(p1);
        people.Add(p2);

        foreach(Person p in people)
        {
            Console.WriteLine(p._firstprompt);
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
            outputFile.WriteLine(p._firstprompt);
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