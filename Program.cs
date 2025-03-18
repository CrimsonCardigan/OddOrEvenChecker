while (true) 

{
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine("Hello! Input a number and I can tell you if it is odd or even.");

    string GivenUserNumber = Console.ReadLine()!;

if (GivenUserNumber.ToLower() == "exit")
    {
        break; // Exit the loop if the user types 'exit'
    }

    int UserNumber;

    bool isValid = int.TryParse(GivenUserNumber, out UserNumber);

      if (!isValid)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Invalid input. Please enter a valid whole number.");
    }
    else
    {
        if (UserNumber % 2 == 0)        //if the number devided by 2 = 0, (it is even)
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