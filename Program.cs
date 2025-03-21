using System;
class Program
{
    static void Main()
    {
        int correctGuesses = 0; // Tracks correct guesses
        int incorrectGuesses = 0; // Tracks incorrect guesses
        Random random = new Random(); // Creates a random number generator

        while (true)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Hello! Input a number and I can tell you if it is odd or even.");
            Console.WriteLine("Type 'Game' to play the odd/even guessing game.");
            Console.WriteLine("Type 'Exit' to quit.");
            Console.ResetColor();

            string GivenUserNumber = Console.ReadLine()!;

            if (GivenUserNumber.ToLower() == "exit")
            {
                break; // Exit the loop if the user types 'exit'
            }







            if (GivenUserNumber.ToLower() == "game") // If the user types "Game"
            {
            while (true)
            { 

                int randomNumber = random.Next(1, 101);  // Generate a random number between 1 and 100
                Console.WriteLine("I have picked the number:" + randomNumber);
                Console.WriteLine("Do you think it's 'odd' or 'even'?");

        
                string userGuess = Console.ReadLine()!.ToLower();  // Get user guess ("odd" or "even")


            if (userGuess.ToLower() == "exit")
            {
                break; // Exit the loop if the user types 'exit'   
            }

                bool isEven = randomNumber % 2 == 0;  // isEven is when it can be divided by two
                bool guessedCorrectly = (userGuess == "even" && isEven) || (userGuess == "odd" && !isEven);


                if (guessedCorrectly)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"Correct! The number {randomNumber} is {userGuess}.");
                    correctGuesses++;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"Wrong! The number {randomNumber} is {userGuess}.");
                    incorrectGuesses++;
                }

                Console.ResetColor();
                Console.WriteLine($"Correct guesses: {correctGuesses} | Incorrect guesses: {incorrectGuesses}");
                Console.WriteLine();
                continue;

            }
             if (GivenUserNumber.ToLower() == "exit")
            {
                break; // Exit the loop if the user types 'exit'
            } 
            continue;
            Console.WriteLine("Thanks for playing!");
            }
            
            // Validate if input is a number
            bool isValid = int.TryParse(GivenUserNumber, out int UserNumber);

            if (!isValid)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Invalid input. Please enter a valid whole number.");
                Console.WriteLine();
            }
            else
            {
                if (UserNumber % 2 == 0) // If the number is even
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("The Number: " + UserNumber + " is even ");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("The Number: " + UserNumber + " is odd ");
                }
                Console.WriteLine();
            }
        }
    }
}