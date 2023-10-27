// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

string name = "Jake";

Console.WriteLine($"Hi there, {name}.");
Console.WriteLine("Hi there, " + name +".");
Console.WriteLine("Enter name here.");
string yourName = Console.ReadLine();
Console.ForegroundColor = ConsoleColor.Magenta;//Change font color
Console.WriteLine($"Hi there {yourName}.");

SomeFunction();

static void SomeFunction()
{
    Console.WriteLine("some function");
}

