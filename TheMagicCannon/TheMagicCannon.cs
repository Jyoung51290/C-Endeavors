for (int number = 1; number <= 100; number++)
{
    string type;
    ConsoleColor color;
    if (number % 5 == 0 && number % 3 == 0)
    {
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine($"{number} : Mega");
    }
    else if (number % 3 == 0)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine($"{number} : Fire");
    }
    else if (number % 5 == 0)
    {
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine($"{number} : Electric");
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.Gray;
        Console.WriteLine($"{number} : Normal");
    }

}