//Program 1

Console.WriteLine("The following items are available:");
Console.WriteLine("1 - Rope (15 gold)");
Console.WriteLine("2 - Torch (30 gold)");
Console.WriteLine("3 - Climbing Equipment (45 gold)");
Console.WriteLine("4 - Clean Water (10 gold)");
Console.WriteLine("5 - Machete (160 gold)");
Console.WriteLine("6 - Canoe (300 gold)");
Console.WriteLine("7 - Food Supplies (50 gold)");
Console.Write("Which number would you want to see the price of? ");

int userInput = Convert.ToInt32(Console.ReadLine());

string itemName = userInput switch
{
    1 => "Rope",
    2 => "Torch",
    3 => "Climbing Equipment",
    4 => "Clean Water",
    5 => "Machete",
    6 => "Canoe",
    7 => "Food Supplies",
    _ => "Unknown"
};

float cost = userInput switch
{
    1 => 15,
    2 => 30,
    3 => 45,
    4 => 10,
    5 => 160,
    6 => 300,
    7 => 50,
    _ => 0
};

Console.WriteLine("What is your name? If it is the same as mine, I will give you 50% off the purchase.");
var userInput2 = Console.ReadLine();
bool SameName = userInput2 == "Jacob";

if (SameName)
{
    Convert.ToDouble(cost);
    cost /= 2;
    Console.WriteLine($"The {itemName} costs {cost} gold.");
}
else
{
    Console.WriteLine($"The {itemName} costs {cost} gold.");
}
Thread.Sleep( 1000 );

//Program 2

int User1Input1;
do
{
    Console.WriteLine("User 1 , enter a number between 0 and 100.");
    User1Input1 = Convert.ToInt32(Console.ReadLine());
}
while (User1Input1 < 0 || User1Input1 > 100);

Console.Clear();
Console.WriteLine("User 2, guess the number. ");

int guess;
do
{
    guess = Convert.ToInt32(Console.ReadLine());

    if (guess == User1Input1) Console.WriteLine("You are correct.");
    else if (guess > User1Input1) Console.WriteLine("Guess lower. ");
    else if (guess < User1Input1) Console.WriteLine("Guess higher. ");
}
while (guess != User1Input1);