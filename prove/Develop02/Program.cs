using System;

class Program
{
    static void Main(string[] args)
    {
        // Create a new journal object
        Journal journal = new Journal();
        int _userChoice = 0;
        List <string> _mainMenu = new List<string>
        {
            "Please select one of the choices",
            "1. Add an entry",
            "2. View all entries",
            "3. Load",
            "4. Save",
            "5. View Tags",
            "6. Quit",
            "What would you like to do?"

        };

        while (_userChoice != 6)
        {
            foreach (string _menuItem in _mainMenu)
            {
                Console.WriteLine(_menuItem);
            }
            _userChoice = int.Parse(Console.ReadLine());
        
            // Switch on the user's choice
            switch (_userChoice) 
            {
                case 1:
                    // Add an entry
                    journal.AddEntry();
                    journal.DisplayJournal();
                    break;
                case 2:
                    // View entries
                    journal.DisplayJournal();
                    break;
                case 3:
                    // Save entries
                    journal.LoadJournalFromFile();
                    break;
                case 4:
                    //View tags
                    journal.SaveJournalToFile();
                    break;
                case 5:
                    //View tags
                    journal.ViewTags();
                    break;            
                case 6:
                    // Quit
                    Console.WriteLine("Goodbye!");
                    return;
                default:
                    // Invalid choice
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }
}