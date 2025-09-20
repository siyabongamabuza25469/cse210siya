using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise2 Project.");

        // Ask the user for their grade percentage
        Console.Write("Enter your grade percentage: ");
        string input = Console.ReadLine();
        
        // Convert the input to a double
        double gradePercentage;
        if (!double.TryParse(input, out gradePercentage)) // Check if conversion is successful
        {
            Console.WriteLine("Invalid input. Please enter a numeric value.");
            return; // Exit if the input is invalid
        }

        // Initialize variables for letter grade and sign
        string letter = string.Empty;
        string sign = string.Empty;

        // Determine the letter grade based on the percentage
        if (gradePercentage >= 90)
        {
            letter = "A";
        }
        else if (gradePercentage >= 80)
        {
            letter = "B";
        }
        else if (gradePercentage >= 70)
        {
            letter = "C";
        }
        else if (gradePercentage >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        // Determine the sign (only for A, B, and C)
        int lastDigit = (int)gradePercentage % 10; // Get the last digit

        if (letter == "A" && gradePercentage < 93)
        {
            if (lastDigit >= 7)
            {
                sign = "+";
            }
            else if (lastDigit < 3)
            {
                sign = "-";
            }
        }
        else if (letter == "B")
        {
            if (lastDigit >= 7)
            {
                sign = "+";
            }
            else if (lastDigit < 3)
            {
                sign = "-";
            }
        }
        else if (letter == "C")
        {
            if (lastDigit >= 7)
            {
                sign = "+";
            }
            else if (lastDigit < 3)
            {
                sign = "-";
            }
        }

        // Print the final letter grade with sign
        Console.WriteLine($"Your letter grade is: {letter}{sign}");

        // Check if the user passed or failed
        if (gradePercentage >= 70)
        {
            Console.WriteLine("Congratulations! You passed the course.");
        }
        else
        {
            Console.WriteLine("Don't be discouraged. Keep trying for next time!");
        }
    }
}
    
