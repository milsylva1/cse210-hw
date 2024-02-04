using System;
using System.IO;

class Program
{
    static void Main()
    {
        

        //I was trying to create some annimations even though i"ve been watching the video over and over
        //but the code doesn't run at all.☝🏾👇🏾
//         Console.WriteLine("Get ready...");

        
//         //|/-\|/-|/
//         List<string> animationStrings = new List<string>();
//         animationStrings.Add("|");
//         animationStrings.Add("/");
//         animationStrings.Add("-");
//         animationStrings.Add("\\");
//         animationStrings.Add("|");
//         animationStrings.Add("/");
//         animationStrings.Add("-");
//         animationStrings.Add("\\");
        
        
//         // foreach (string s in animationStrings)
//         // {
//         //     Console.Write(s);
//         //     Thread.Sleep(1000);
//         //     Console.Write("\b \b");
//         // }
        
//         DateTime startTime = DateTime.Now;
//         DateTime EndTime = startTime.AddSeconds(10);

//         int i = 0;

//         while (DateTime.Now < EndTime)
//         {
//             string s = animationStrings[i];
//             Console.Write(s);
//             Thread.Sleep(1000);
//             Console.Write("\b \b");

//             i++;
//             if ( i >= animationStrings.Count)
//             {
//                 i = 0;
//             }
//         }

//        Console.WriteLine("");
//         Console.WriteLine("Well done!");
//     }☝🏾
// }

        Journal journal = new Journal();

        Prompt prompt = new Prompt();
        prompt.AddPrompt("Welcome to the breathing activity. ");
        prompt.AddPrompt("How long in Second would you like for session. ");
        prompt.AddPrompt("Wis it work? ");
        prompt.AddPrompt("How long would you like to pass with us? ");
        prompt.AddPrompt("did you appeciate it? ");

        int option = 0;

        while (option != 5)
        {
            Console.WriteLine("Menu Option: ");
            Console.WriteLine("1. Start breathing activity");
            Console.WriteLine("2. Start reflecting activity");
            Console.WriteLine("3. Start listing Acivity");
            Console.WriteLine("4. Nothing");
            Console.WriteLine("5. Quit");
            Console.Write("Select a choice from menu: ");
            option = int.Parse(Console.ReadLine());
            
            if (option == 1)
            {
                string randomPrompt = prompt.GetRandomPrompt();
                Console.WriteLine(randomPrompt);

                string journalEntry = Console.ReadLine();

                Entry entry = new Entry();
                entry._date = DateTime.Now.ToShortDateString();
                entry._prompt = randomPrompt ;
                entry._journalEntry = journalEntry;
            
                journal.AddEntry(entry);
            }
            else if (option == 2)
            {
                journal.DisplayEntries();
            }
            else if (option == 3)
            {
                Console.WriteLine("Wrong option");
                string fileName = Console.ReadLine();

                journal.SaveEntries(fileName);
            }
        }
    }
}