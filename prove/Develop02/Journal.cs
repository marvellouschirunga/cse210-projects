using System;
using System.Collections.Generic;
using static Tag;


public class Journal {

    public List<Entry> _entries = new List<Entry>(); //This variable takes the shape of an Entry class, therfore it has a list of entries that have a Date, Promt and Response 
    public List<Tag> _tags = new List<Tag>(); 
    
    //this is a constructor for Journal Class
    public Journal() 
    {
    }
    
    //This is a method gets a random prompt from the list of prompts from line 73 - 76
    public void AddEntry() 
    {
        // Show the user a random prompt
        PromptGenerator userPrompt = new PromptGenerator();
        string _prompt = userPrompt.GetRandomPrompt();
     
        // Get the user's response
        Console.WriteLine("What is your response to the prompt \"" + _prompt + "\"?"); //the user than types in their response
        string _response = Console.ReadLine(); //the response is then saved in a variable called response
        Console.WriteLine("Add a tag to this entry "); //the user than types in their desired tag
        string _tag = Console.ReadLine(); //the response is then saved in a variable called response

        // Create a new entry
        Entry entry = new Entry(DateTime.Now , _prompt, _response); //initialises a new Entry from the Entry class and this entry had fields of Date, Prompt and Response
        entry._date = DateTime.Now; //takes in the date 
        //entry._tags
        entry._tags = new List<Tag>(); //initializes a new list for tags
        entry._prompt = _prompt; // takes in the prompt
        entry._response = _response; // takes in the response
        // Convert the string to a tag.
        Tag tag = new Tag(_tag);

        // Add the tag to the entry.
        entry._tags.Add(tag);
        // Add the entry to the journal
        _entries.Add(entry); 
        _tags.Add(tag);
        

    }


    // a method called Display Journal
    public void DisplayJournal() 
    {
        // Iterates through the list of entries and display them to the screen
        foreach (Entry entry in _entries) 
        {
            Console.WriteLine(entry._date + " | " + entry._prompt + " | " + entry._response);
        }
    }

    //Writes the jounal to a file
    public void SaveJournalToFile() 
    {
        // Prompt the user for a filename
        Console.WriteLine("Enter a filename to save the journal to:");
        string filename = Console.ReadLine();

        // Save the journal to the file
        using (StreamWriter writer = new StreamWriter(filename)) {
            foreach (Entry entry in _entries) {
                writer.WriteLine(entry._date + " | " + entry._prompt + " | " + entry._response);
            }
        }
    }

    //Loads the journal from a file
    public void LoadJournalFromFile() 
    {
        // Prompt the user for a filename
        Console.WriteLine("Enter a filename to load the journal from:");
        string filename = Console.ReadLine();

        // Load the journal from the file
        using (StreamReader reader = new StreamReader(filename)) {
    try {
        string line;
        while ((line = reader.ReadLine()) != null) {
            string[] parts = line.Split('|');
            Entry entry = new Entry(DateTime.Parse(parts[0]), parts[1], parts[2]);
            entry._date = DateTime.Parse(parts[0]);
            entry._prompt = parts[1];
            entry._response = parts[2];
            _entries.Add(entry);
        }
    } catch (Exception e) {
        Console.WriteLine("Error reading file: " + e.Message);
    }
}

    }

    public void ViewTags() 
{
    // Iterates through the list of entries and displays their tags to the screen
    foreach (Entry entry in _entries) 
    {
        foreach (Tag tag in entry._tags) 
        {
            Console.WriteLine(tag._tagName);
        }
    }
}



    
}