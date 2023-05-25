using System;
using static System.Console;

class Program
{
    static void Main(string[] args)
    {
        Clear();
        var choice = "";
        while (choice != "4")
        {
            // Type the menu options using the TypeLine() function.
            TypeLine("Menu options:");
            WriteLine();
            WriteLine("  1.Start breathing actvity");
            WriteLine("  2.Start reflecting activity");
            WriteLine("  3.Start listing activity");
            WriteLine("  4.Quit ");
            WriteLine();

            // Write a prompt for the user to enter their choice.
            TypeLine("Select a choice from the above menu: ");
            choice = ReadLine();

            // Switch on the user's choice and execute the corresponding action.
            switch (choice)
            {
            case "1":
                var _breathing = new Breathing();
                _breathing.ShowBreathingActivity();
                break;
            case "2":
                var _reflecting = new Reflecting();
                _reflecting.ShowReflectingActivity();
                break;
            case "3":
                var _listing = new Listing();
                _listing.ShowListingActivity();
                break;
            case "4":
                Clear();
                return;
            default:
                WriteLine("Invalid choice.");
                break;
            }
        }   
    }

    static void TypeLine(string line) {
        for (int i = 0; i < line.Length; i++) {
            Console.Write(line[i]);
            System.Threading.Thread.Sleep(60); // Sleep for 150 milliseconds
        }
    }
}
