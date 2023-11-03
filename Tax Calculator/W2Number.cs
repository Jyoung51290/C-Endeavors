namespace Tax_Calculator
{
    internal class W2Number
    {
        public static void Main(string[] args)
        {
            string W2Number;
            Console.Write("How many W2 forms will be used? ");
            W2Number = Console.ReadLine();
            Console.WriteLine("You entered {0}.", W2Number);
 
            var marriageStatus = new MarriageStatus();
            marriageStatus.AskMarriageStatus();
        }
    }
}

