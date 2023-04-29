public class PromptGenerator
{
    public List<string> prompts = new List<string>();

    //This is a private class so only accessible by the methods in the same class such as the WriteEntry() and not directly by any methdod outside the Journal class
    public string GetRandomPrompt() {
        // Get a list of prompts
        List<string> prompts = new List<string>(); //creates an object called Prompts, that takes in a list of prompts manually added by you below
        prompts.Add("What was the best part of your day?");
        prompts.Add("How did I see the hand of the Lord in my life today?"); //promts.Add() is a method for adding the string into the prompts List of strings
        prompts.Add("What was the strongest emotion I felt today?");
        prompts.Add("If I had one thing I could do over today, what would it be?");

        // Get a random prompt from the list
        Random random = new Random();
        int randomIndex = random.Next(prompts.Count);
        return prompts[randomIndex];
    }
}