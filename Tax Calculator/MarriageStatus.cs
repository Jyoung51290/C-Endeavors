using TaxCalculator;

namespace Tax_Calculator
{
    internal class MarriageStatus

    {
        int NumberofW2;
        public MarriageStatus(int NumberofW2)
        {
            this.NumberofW2 = NumberofW2;
        }
        public void AskMarriageStatus()
        {
            Console.WriteLine("1. Single");
            Console.WriteLine("2. Married");
            Console.WriteLine("Select filing status: 1 or 2");
            int filingStatusChoice = Convert.ToInt32(Console.ReadLine());

            var Program = new program(NumberofW2,filingStatusChoice);
            Program.Askprogram();
        }
    }
}
