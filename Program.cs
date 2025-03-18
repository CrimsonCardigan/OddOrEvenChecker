while (true) {
    Console.WriteLine("Hello. Input a number and I can tell you if it is odd or even.");

    var GivenUserNumber = Console.ReadLine();
    int UserNumber = int.Parse(GivenUserNumber);

    if (UserNumber % 2 == 0)        //if the number devided by 2 = 0, (it is even)
    {
        Console.WriteLine("The Number: " + UserNumber + " is even ");
    }
    else
    {
        Console.WriteLine("The Number: " + UserNumber + " is odd ");
    }

    Console.WriteLine();
}
