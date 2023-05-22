using System;

class Program
{
    static Scripture scripture = new Scripture();

    static void Main(string[] args)
    {
        Reference reference;
        
        // The program read a JSON file and prompts the user to choose a scripture as exeeding requirements.
        int userInput = DisplayMenu();
        if (userInput == 0) reference = scripture.ChooseRandom();
        else reference = scripture.ChooseOne(userInput - 1);

        continuousHidding(reference);
    }

    static int DisplayMenu()
    {
        Console.WriteLine("0 — Random Scripture.\n");
        scripture.DisplayLibrary();
        Console.WriteLine();
        Console.Write("Please enter the number corresponding to the verse you want to memorise: ");
        string userInput = Console.ReadLine();
        if (userInput != "") return int.Parse(userInput);

        return 0;
    }

    static void continuousHidding(Reference original)
    {
        Word.getInstance().RandomlyHideWords(original);
    }
}