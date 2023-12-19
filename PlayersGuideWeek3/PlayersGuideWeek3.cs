//Program 1

Console.WriteLine("How many estates?");
string estatesStr = Console.ReadLine();
int estates = Convert.ToInt32(estatesStr);
Thread.Sleep(400);

Console.WriteLine("How many provinces?");
string provincesStr = Console.ReadLine();
int provices = Convert.ToInt32(provincesStr);
Thread.Sleep(400);

Console.WriteLine("How many duchies?");
string duchiesStr = Console.ReadLine();
int duchies = Convert.ToInt32(duchiesStr);

int totalEstates = estates * 1;
int totalProvices = provices * 6;
int totalduchies = duchies * 3;

Thread.Sleep(700);
Console.WriteLine("The totals are :" + totalEstates + " estates, " + totalProvices + " provices, " + totalduchies + " duchies");
int CombinedPoints = totalduchies + totalEstates + totalProvices;

Thread.Sleep(1000);
Console.WriteLine("If we combine all of the points we get " + CombinedPoints + " points!");
Thread.Sleep(700);

//Program 2

{
    while (true)
    {
        Console.WriteLine("Target Row? ");
        var UserInput1 = Convert.ToInt32(Console.ReadLine());
        Thread.Sleep(400);
        Console.WriteLine("Target Column? ");
        var UserInput2 = Convert.ToInt32(Console.ReadLine());

        int FirstPositionX = UserInput1;
        int FirstPositionY = UserInput2 - 1;

        int SecondPositionX = UserInput1 - 1;
        int SecondPositionY = UserInput2;

        int ThirdPositionX = UserInput1;
        int ThirdPositionY = UserInput2 + 1;

        int FourthPositionX = UserInput1 + 1;
        int FourthPositionY = UserInput2;

        if (DisplayPositions(FirstPositionX, FirstPositionY, SecondPositionX, SecondPositionY,
                            ThirdPositionX, ThirdPositionY, FourthPositionX, FourthPositionY))
        {
            Thread.Sleep(700);
            Console.WriteLine("Successfully positioned.");
            Thread.Sleep(700);
            break;
        }
        else
        {
            Thread.Sleep(700);
            Console.WriteLine("Unable to position.");
            Thread.Sleep(700);
            Restart();
        }
    }
}

static bool DisplayPositions(int FirstX, int FirstY, int SecondX, int SecondY,
                             int ThirdX, int ThirdY, int FourthX, int FourthY)
{
    Thread.Sleep(700);
    Console.WriteLine("Deploy to " +
                      $"({FirstX},{FirstY}), ({SecondX},{SecondY}), ({ThirdX},{ThirdY}), ({FourthX},{FourthY}).");

    bool isValid = IsValidCoordinate(FirstX) && IsValidCoordinate(FirstY) &&
                   IsValidCoordinate(SecondX) && IsValidCoordinate(SecondY) &&
                   IsValidCoordinate(ThirdX) && IsValidCoordinate(ThirdY) &&
                   IsValidCoordinate(FourthX) && IsValidCoordinate(FourthY);

    return isValid;
}
static bool IsValidCoordinate(int coordinate)
{
    return coordinate >= 1 && coordinate <= 8;
}
static void Restart()
{
    Thread.Sleep(700);
    Console.WriteLine("Please try again.");
}

//Program 3

Console.WriteLine("Please enter the number. ");
int Number = int.Parse(Console.ReadLine());
Thread.Sleep(400);
if (Number % 2 == 0)
{
    Console.WriteLine("Tick");
    Thread.Sleep(400);
}
else
{
    Console.WriteLine("Tock");
    Thread.Sleep(400);
}

//Program 4

Console.WriteLine("Enter the number for the x coordinate location.");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the number for the y coordinate location.");
int y = Convert.ToInt32(Console.ReadLine());

if (x == 0 && y == 0)
{
    Console.WriteLine("The enemy is here!");
}
if (x == 0 && y > 0)
{ 
    Console.WriteLine("The enemy coming from the north!");
}
if (x == 0 && y < 0)
{
    Console.WriteLine("The enemy is coming from the south!");
}
if (x < 0 && y == 0)
{
    Console.WriteLine("The enemy is coming from the west!");
}
if (x > 0 && y == 0)
{
    Console.WriteLine("The enemy is coming from the east!");
}
if (x < 0 && y > 0)
{
    Console.WriteLine("The enemy is coming from the northwest!");
}
if (x > 0 && y > 0)
{
    Console.WriteLine("The enemy is coming from the northeast!");
}
if (x < 0 && y < 0)
{
    Console.WriteLine("The enemy is coming from the southwest!");
}
if (x > 0 && y < 0)
{
    Console.WriteLine("The enemy is coming from the southeast!");
}