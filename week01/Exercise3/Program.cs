using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise3 Project.");

         // Start the game loop
        PlayGame();
    }

    static void PlayGame()
    {
        Random random = new Random();
        int magicNumber = random.Next(1, 101); // Generate a random number between 1 and 100
        int guess = 0;
        int guessCount = 0; // Variable to count guesses

        Console.WriteLine("Welcome to 'Guess My Number'!");

        while (guess != magicNumber)
        {
            Console.Write("What is your guess? ");
            guess = Convert.ToInt32(Console.ReadLine());
            guessCount++;

            if (guess < magicNumber)
            {
                Console.WriteLine("Higher");
            }
            else if (guess > magicNumber)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("You guessed it!");
                Console.WriteLine($"It took you {guessCount} guesses.");
            }
        }

        // Ask if the player wants to play again
        string playAgain;
        do
        {
            // Reset game variables
            magicNumber = random.Next(1, 101);
            guess = 0;
            guessCount = 0;

            Console.WriteLine("Welcome to 'Guess My Number'!");

            while (guess != magicNumber)
            {
                Console.Write("What is your guess? ");
                guess = Convert.ToInt32(Console.ReadLine());
                guessCount++;

                if (guess < magicNumber)
                {
                    Console.WriteLine("Higher");
                }
                else if (guess > magicNumber)
                {
                    Console.WriteLine("Lower");
                }
                else
                {
                    Console.WriteLine("You guessed it!");
                    Console.WriteLine($"It took you {guessCount} guesses.");
                }
            }

            Console.Write("Do you want to play again? (yes/no): ");
            playAgain = Console.ReadLine().ToLower();

        } while (playAgain == "yes");

        Console.WriteLine("Thank you for playing!");
    }
}
    

