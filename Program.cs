class Program
{
    static void Main()
    {
        Random random = new Random(); // Creates a random number generator

        while (true)
        {
            bool result = RunProcess(random);
            if (result == false)
            {
                break;
            }
        }
    }

    static bool RunProcess(Random random)
    {
        var userInput = GetUserInput();

        if (userInput == "exit")
        {
            return false;
        }
        else if (userInput == "game")
        {
            PlayGame(random);
        }
        else
        {
            DoOddOrEven(userInput);
        }

        Console.WriteLine();

        return true;
    }

    static string GetUserInput()
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("Hello! Input a number and I can tell you if it is odd or even.");
        Console.WriteLine("Type 'Game' to play the odd/even guessing game.");
        Console.WriteLine("Type 'Exit' to quit.");
        Console.ResetColor();

        string userInput = Console.ReadLine()!.ToLower();
        return userInput;
    }

    static void DoOddOrEven(string userInput)
    {
        bool isValid = int.TryParse(userInput, out int userNumber);

        if (isValid)
        {
            if (userNumber % 2 == 0) // If the number is even
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("The Number: " + userNumber + " is even ");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("The Number: " + userNumber + " is odd ");
            }
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Invalid input. Please enter a valid whole number.");
        }
    }

    static void PlayGame(Random random)
    {
        int correctGuesses = 0; // Tracks correct guesses
        int incorrectGuesses = 0; // Tracks incorrect guesses
        while (true)
        {
            int randomNumber = random.Next(1, 101);  // Generate a random number between 1 and 100
            Console.WriteLine("I have picked the number:" + randomNumber);
            Console.WriteLine("Do you think it's 'odd' or 'even'?");

            string userGuess = Console.ReadLine()!.ToLower();  // Get user guess ("odd" or "even")

            var opposite = "";
            if (userGuess == "exit")
            {
                break; // Exit the loop if the user types 'exit'   
            }
            else if (userGuess == "even")
            {
                opposite = "odd";
            }
            else if (userGuess == "odd")
            {
                opposite = "even";
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter even, odd, or exit");
                Console.WriteLine();
                continue;
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
                Console.WriteLine($"Wrong! The number {randomNumber} is {opposite}.");
                incorrectGuesses++;
            }

            Console.ResetColor();
            Console.WriteLine($"Correct guesses: {correctGuesses} | Incorrect guesses: {incorrectGuesses}");
            Console.WriteLine();
        }
        Console.WriteLine("Thanks for playing!");
    }
}