using System.Formats.Asn1;

// Stores data under the variable "thing"
string thing;
// Iniates the console with a starting question
Console.WriteLine("What kind of thing are we talking about?.");
// Bonds the user input to the variable string "thing"
thing = Console.ReadLine();
// Causes a 700 milisecond delay after the user answer, before prompting the follow up question
Thread.Sleep(700);
// Stores data under the variable "description"
string description;
// asks a follow up question via console
Console.WriteLine("How would you describe it? Big? Azure? Tattered?");
// Bonds the user input to the variable string "description"
description = Console.ReadLine();
// Causes a 700 milisecond delay after the user answer
Thread.Sleep(700);
// Causes a 400 milisecond delay after the user answer
Thread.Sleep(400);
// Puts all of the strings together with some texts in order to diaplay the final console message
Console.WriteLine("The " + description + " " + thing + " of Doom 3000!");


Console.WriteLine("How many inches is the size of the base? ");
string baseSizeStr = Console.ReadLine();
double baseSize = Convert.ToDouble(baseSizeStr);

Console.WriteLine("How many inches is the height? ");
string heightStr = Console.ReadLine();
double height = Convert.ToDouble(heightStr);

double area = (height * baseSize) / 2;
Console.WriteLine("The area is " + area + " square inches.");


 