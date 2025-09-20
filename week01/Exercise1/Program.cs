using System;

class Program
{
    static void Main(string[] args)
    {
        // Prompt for first name
        Console.WriteLine("Hello World! This is the Exercise1 Project.");
        Console.WriteLine("What is your first name? "); // Prompts the user for their first name
        string firstName = Console.ReadLine(); // Reads the user's input from the console and stores it in 'firstName'

        // Prompt for last name
        Console.Write("What is your last name? "); // Prompts the user for their last name
        string lastName = Console.ReadLine(); // Reads the user's input from the console and stores it in 'lastName'

        // Display the result
        Console.WriteLine($"Your name is {lastName}, {firstName} {lastName}."); // Displays the formatted name to the console
    }
}
    


    
