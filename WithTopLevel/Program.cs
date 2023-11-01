namespace WithTopLavel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            int[] numbers = { 1, 2, 3, 4, 5 };
            int[] usersNumbers = new int[5];
            for (int index = 0; index < numbers.Length; index++)
            {
                Console.WriteLine($"Please enter a number.{index+1}");
                usersNumbers[index] = Convert.ToInt32(Console.ReadLine()); //Creates a list of 5 numbers
            }
            foreach (var userNumbers in usersNumbers)
            {
                Console.WriteLine(userNumbers);
            }

            var name = "Jake";

            changeString(name);

            var number = SomeMethodDoesThisSpecialOtherThing();

            double otherNumber = 4.2;

            Console.WriteLine("Please enter a number.");
            var input = Console.ReadLine();

            var inputAsNumeric = int.Parse(input);
            inputAsNumeric = Convert.ToInt32(input);

            if (inputAsNumeric > 0 && inputAsNumeric < 100)
            {
                Console.WriteLine("Your number is 0-100.");
            }

            else
            {
                Console.WriteLine("Your number is too high or too low.");
            }
            var result = inputAsNumeric > 100 ? "Too high" : "Ok";//If Else in a single line

            Console.WriteLine($"{otherNumber} * {inputAsNumeric} == {otherNumber * inputAsNumeric}");

            Console.WriteLine($"5/2=={5 / 2}");
            Console.WriteLine($"5/2=={5 / 2.0}");// 2.0, etc. is always detected as a double.
            Console.WriteLine($"5/2=={5 / inputAsNumeric}");

            Console.WriteLine($"What is 5 + 6 / 2 * 3 ?");
            var answer = (5 + 6 / 2 * 3);
            Console.WriteLine(answer);

            Console.Beep(1000, 1000);


            SomeFunction();
            SomeMethodDoesThisSpecialOtherThing();
        }

        static void changeString(string value)
        {
            value = "Test";
        }

        static int doubleNumber(int number) => number * 2;
            static int doubleNumberLongForm(int number)
            {
                return number * 2;
            Console.WriteLine(number);
            }

        static string getChoice(int choice)
        {
            string response;
            response = choice switch
            { //This is an example of a switch....video game style
                1 => "Ye rest and recover your health.",
                2 => "Raiding the port will get ye 50 gold doubloons.",
                3 => "The wind is at your back; the open horizen ahead.",
                4 => "Tis but a baby Kraken, but still eats toy boats.",
                _ => "Apologies. I do not know that one."
            };   
                return response;
            
        }

        static bool IsOneBiggerThanTwo(int number1, int number2)
        {
            return number1 > number2; //This is a one line if/else
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