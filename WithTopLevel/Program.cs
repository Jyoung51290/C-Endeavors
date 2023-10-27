using System;

namespace WithTopLavel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            var name = "Jake";
            var number = SomeMethodDoesThisSpecialOtherThing();

            double otherNumber = 4.2;

            Console.WriteLine("Please enter a number.");
            var input = Console.ReadLine();

            var inputAsNumeric = Convert.ToDouble(input);
           
            Console.WriteLine($"{otherNumber} * {inputAsNumeric} == {otherNumber * inputAsNumeric}");

            Console.WriteLine($"5/2=={5 / 2}");
            Console.WriteLine($"5/2=={5 / 2.0}");// 2.0, etc. is always detected as a double.
            Console.WriteLine($"5/2=={5 / inputAsNumeric}");
           

            SomeFunction();
            SomeMethodDoesThisSpecialOtherThing();
        }

        static void SomeFunction()
        {
            Console.WriteLine("Some function");
        }

        static double SomeMethodDoesThisSpecialOtherThing()
        {
            return 7.7;
        }
    }
}