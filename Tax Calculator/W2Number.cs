namespace Tax_Calculator
{
    internal class W2Number
    {
        public static void Main(string[] args)
        {
            string W2Number;
            Console.Write("Enter number of W2 forms? ");
            W2Number = Console.ReadLine();
            int NumberofW2 = Convert.ToInt32(W2Number);
            double totalTaxableIncome = 0;
            var marriageStatus = new MarriageStatus(NumberofW2);
            marriageStatus.AskMarriageStatus();


        }

}
}

