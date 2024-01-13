using System;

namespace prep1
{
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your first name? ");
        string first = Console.ReadLine();
        Console.Write("What is your last name? ");

        string last = Console.ReadLine();

        Console.WriteLine($"Your Name is {last}, {first}, {last}");
    }
}
}