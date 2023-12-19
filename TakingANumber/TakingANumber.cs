int eggCount = AskForNumberInRange("How many chocolate eggs are there today? ", 0, int.MaxValue);

int ForSisters = eggCount / 4;
int ForDuckbear = eggCount % 4;

Console.WriteLine("Each sister gets  " + ForSisters + ".");
Console.WriteLine("The Duckbear gets " + ForDuckbear + ".");

int AskForNumber(string text)
{ 
    Console.Write(text);
    int chosenNumber = Convert.ToInt32(Console.ReadLine());
    return chosenNumber;
}

int AskForNumberInRange(string text, int min, int max)
{
    while (true)
    {
        Console.Write(text);
        int chosenNumber = Convert.ToInt32(Console.ReadLine());
        if (chosenNumber >= min && chosenNumber <= max)
        return chosenNumber;
    }
}
